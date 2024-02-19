using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using ZXing;
using System.Diagnostics;
using _221047_registros.Models;
using System.Drawing.Printing;

namespace _221047_registros.Views
{
    public partial class FrmCaixa : Form
    {
        public double total, accumulate = 0, accumulateCash = 0, accumulateCard = 0, accumulatePIX = 0, accumulateDraft = 0, accumulateSlip = 0;
        public int sell_value, recorder_value, client_id;
        public string client_cpf, client_name;

        public FrmCaixa(double totalVenda, int idVendaGravada, int idCliente, string cpfCliente, string nomeCliente)
        {
            InitializeComponent();

            total = totalVenda;
            recorder_value = idVendaGravada;
            client_id = idCliente;
            client_cpf = cpfCliente;
            client_name = nomeCliente;
        }

        public void clearAllOptions()
        {
            txt_cashPayValue.Clear();
            txt_cardaccountPayValue.Clear();
            txt_bankdraftPayValue.Clear();

            lbl_changeCashValue.Text = (0).ToString("C");

            btn_cardaccountRequest.Visible = false;
            btn_cardaccountRequest.BackColor = System.Drawing.ColorTranslator.FromHtml("#f78205");
            btn_cardaccountRequest.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffd678");

            prb_load.Visible = false;

            grb_cashOption.Visible = false;
            grb_cardaccountOption.Visible = false;
            grb_bankdraftOption.Visible = false;
            grb_bankslipOption.Visible = false;
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            lbl_clientId.Text = client_id.ToString();
            lbl_clientCpf.Text = client_cpf;

            lbl_saleSummation.Text = total.ToString("C");
            lbl_remaining.Text = total.ToString("C");

            cmb_payOptions.SelectedIndex = 0;
        }

        private void cmb_payOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllOptions();

            switch (cmb_payOptions.Text)
            {
                case "Á Vista":
                    grb_cashOption.Visible = true;
                    txt_cashPayValue.Select();
                    break;
                case "Cartão - Cred/Deb":
                    lbl_optionmessage.Text = "SOLICITAÇÃO VIA MÁQUINA:";
                    btn_cardaccountRequest.Text = "CARTÃO REQUISITADO NA MÁQUINA";
                    grb_cardaccountOption.Visible = true;
                    txt_cardaccountPayValue.Select();
                    break;
                case "PIX":
                    lbl_optionmessage.Text = "VALOR MENCIONADO NO PIX:";
                    btn_cardaccountRequest.Text = "O QR CODE E CHAVE PIX FORAM EXIBIDOS NA MÁQUINA";
                    grb_cardaccountOption.Visible = true;
                    txt_cardaccountPayValue.Select();
                    break;
                case "Cheque":
                    grb_bankdraftOption.Visible = true;
                    txt_bankdraftPayValue.Select();
                    break;
                case "Boleto":
                    lbl_bankslipAccount.Text = $"{client_cpf}|{DateTime.Now:ddMMyyyy}";
                    grb_bankslipOption.Visible = true;
                    btn_downloadBankslip.Select();
                    break;
            }
        }

        public bool checkvalue(TextBox txt)
        {
            txt.Select();

            if (txt.Text == String.Empty || txt.Text == "" || double.Parse(txt.Text) <= 0)
            {
                MessageBox.Show("Não é válida a quantia indicada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void checkpay(double value, Button btn)
        {
            accumulate += value;
            lbl_remaining.Text = (total - accumulate).ToString("C");

            if (accumulate >= total)
            {
                grb_remaining.Visible = false;
                btn_finishPay.Enabled = true;
                btn_finishPay.BackColor = System.Drawing.ColorTranslator.FromHtml("#22374d");
                cmb_payOptions.Enabled = false;

                if (btn != null)
                    btn.Enabled = false;
            }
        }


        private void btn_confirmCash_Click(object sender, EventArgs e)
        {
            if (checkvalue(txt_cashPayValue))
            {
                if (double.Parse(txt_cashPayValue.Text) >= (total - accumulate))
                {
                    double cashchange = double.Parse(txt_cashPayValue.Text) - total;
                    lbl_changeCashValue.Text = cashchange.ToString("C");
                }

                accumulateCash += double.Parse(txt_cashPayValue.Text);
                checkpay(double.Parse(txt_cashPayValue.Text), btn_confirmCash);
            }
            txt_cashPayValue.Clear();
        }

        private async void btn_confirmCardaccount_Click(object sender, EventArgs e)
        {
            prb_load.Visible = true;
            btn_confirmCardaccount.Enabled = false;
            await Task.Run(async () =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    await Task.Delay(100);
                    prb_load.Invoke((MethodInvoker)delegate
                    {
                        prb_load.Value = i;
                    });
                }
            });
            await Task.Delay(2000);
            prb_load.Visible = false;
            if (checkvalue(txt_cardaccountPayValue))
            {
                btn_cardaccountRequest.Visible = true;
                await Task.Delay(2000);

                btn_cardaccountRequest.Text = "PAGAMENTO APROVADO COM SUCESSO!";
                btn_cardaccountRequest.ForeColor = System.Drawing.ColorTranslator.FromHtml("#143d2c");
                btn_cardaccountRequest.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");

                if (cmb_payOptions.Text == "Cartão - Cred/Deb")
                    accumulateCard += double.Parse(txt_cardaccountPayValue.Text);
                else
                    accumulatePIX += double.Parse(txt_cardaccountPayValue.Text);

                btn_confirmCardaccount.Enabled = true;
                checkpay(double.Parse(txt_cardaccountPayValue.Text), btn_confirmCardaccount);
                await Task.Delay(3000);

                cmb_payOptions.SelectedIndex = cmb_payOptions.FindString(cmb_payOptions.Text);

            }
            txt_cardaccountPayValue.Clear();
        }

        private void btn_confirmBankdraft_Click(object sender, EventArgs e)
        {
            if (checkvalue(txt_bankdraftPayValue))
            {
                MessageBox.Show("O cheque foi validado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accumulateDraft += total;
                checkpay(double.Parse(txt_bankdraftPayValue.Text), btn_confirmBankdraft);
            }
            txt_bankdraftPayValue.Clear();
        }

        private void btn_downloadBankslip_Click(object sender, EventArgs e)
        {
            btn_downloadBankslip.Enabled = false;
            btn_downloadBankslip.BackColor = System.Drawing.ColorTranslator.FromHtml("#1d164a");

            string local_CNPJ = "03.166.122/0309-40";
            string barcode_index = "216279480982394985786267023560293";
            string PDF_name = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", $"boleto_{client_cpf}_sob{DateTime.Now:ddMMyyyy}.pdf");
            double final_value = total-accumulate;

            FileStream recorderPDF = new FileStream(PDF_name, FileMode.Create);
            Document document = new Document(PageSize.POSTCARD);
            PdfWriter.GetInstance(document, recorderPDF);
            document.Open();

            document.Add(new Paragraph("SIMULAÇÃO DE BOLETO COMO TÍTULO", FontFactory.GetFont(FontFactory.COURIER_BOLD, 18, BaseColor.DARK_GRAY)) { Alignment = Element.ALIGN_CENTER });

            iTextSharp.text.Font summmation_font = FontFactory.GetFont(FontFactory.HELVETICA_BOLDOBLIQUE, 16, BaseColor.GRAY);
            iTextSharp.text.Font date_font = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10, BaseColor.DARK_GRAY);
            iTextSharp.text.Font default_font = FontFactory.GetFont(FontFactory.HELVETICA, 14, BaseColor.BLACK);

            document.Add(new Paragraph($"TOTAL: {final_value.ToString("C")}\n", summmation_font) { Alignment = Element.ALIGN_RIGHT });
            document.Add(Chunk.NEWLINE);

            document.Add(new Paragraph($"Emissão: {DateTime.Now:dd/MM/yyyy - hh:mm:ss}\n", date_font));
            document.Add(new Paragraph($"Vencimento: {DateTime.Now.AddDays(5):dd/MM/yyyy}\n", date_font));
            document.Add(Chunk.NEWLINE);

            document.Add(new Paragraph($"Nome: {client_name}\n", default_font));
            document.Add(new Paragraph($"CPF: {client_cpf}\n", default_font));
            document.Add(new Paragraph($"CNPJ: {local_CNPJ}\n", default_font));
            document.Add(Chunk.NEWLINE);


            var barcodeImage = CodeBar(barcode_index);
            var barcodeElement = iTextSharp.text.Image.GetInstance(barcodeImage, BaseColor.WHITE);
            barcodeElement.SetAbsolutePosition((document.PageSize.Width - barcodeImage.Width) / 2, barcodeElement.AbsoluteY);
            document.Add(barcodeElement);

            document.Close();

            MessageBox.Show("PDF criado com sucesso!");
            accumulateSlip += total;
            checkpay(final_value, null);

            Process.Start(PDF_name);
        }


        // DUVIDA - AJUDA EM SERVER DO DISCORD
        private Bitmap CodeBar(string codigo)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;
            Bitmap barcodeBitmap = barcodeWriter.Write(codigo);

            return barcodeBitmap;
        }

        private async void btn_finishPay_Click(object sender, EventArgs e)
        {
            btn_finishPay.Enabled = false;
            btn_finishPay.BackColor = System.Drawing.ColorTranslator.FromHtml("#02172b");
            await Task.Delay(2000);

            Caixa cash_desk = new Caixa()
            {
                desk_recorderid = recorder_value,
                desk_cash = accumulateCash,
                desk_card = accumulateCard,
                desk_PIX = accumulatePIX,
                desk_draft = accumulateDraft,
                desk_slip = accumulateSlip
            };

            cash_desk.Incluide();

            FrmVendas newSale = new FrmVendas();

            newSale.Show();
            this.Hide();

        }

        public void keys_double(KeyPressEventArgs i, TextBox txt)
        {
            if (!char.IsControl(i.KeyChar) && !char.IsDigit(i.KeyChar) &&
            (i.KeyChar != ','))
            {
                i.Handled = true;
            }

            if ((i.KeyChar == ','))
            {
                if (txt.Text.Contains(","))
                {
                    i.Handled = true;
                }
            }
        }

        private void txt_cashPayValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            keys_double(e, txt_cashPayValue);
        }

        private void txt_cardaccountPayValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            keys_double(e, txt_cardaccountPayValue);
        }

        private void txt_bankdraftPayValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            keys_double(e, txt_bankdraftPayValue);
        }
    }
}
