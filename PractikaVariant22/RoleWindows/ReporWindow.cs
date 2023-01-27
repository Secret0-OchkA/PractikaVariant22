using Domain;
using Infrastructura;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractikaVariant22.RoleWindows
{
    public partial class ReporWindow : Form
    {
        private readonly Form parent;

        public ReporWindow(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private async void button_CreatePdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        //Save pdf file
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        IEnumerable<Contract> contracts = await DbContext.Contracts.GetAllAsync();
                        doc.Add(new Header("Contracts","created contracts"));
                        foreach (Contract contract in contracts)
                            doc.Add(new Paragraph(
                                $"{nameof(contract.CompanyId)}: {contract.CompanyId}, " +
                                $"{nameof(contract.Price)}: {contract.Price}, " +
                                $"{nameof(contract.EmployeeId)}: {contract.EmployeeId}" +
                                $"{nameof(contract.DateCreate)}: {contract.DateCreate}"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }

            return;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
