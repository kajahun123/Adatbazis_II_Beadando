using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Konyvtar.Models.Manager;
using Konyvtar.Models.Records;

namespace Konyvtar
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgWorker;
        List<Konyvek> konyvekList;
        KonyvManager konyvmanager;
        public Form1()
        {
            InitializeComponent();
            konyvmanager = new KonyvManager();
            konyvekList = new List<Konyvek>();
            bgWorker = new BackgroundWorker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            cb_mufaj.DataSource = Enum.GetValues(typeof(Mufaj));
            InitDataGridView();
        }

        private void Form1_Show(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            Konyvek konyv = new Konyvek()
            {
                Olvasojegy = tb_olvasojegy.Text,
                KolcsonzoNev = tb_kolcsonzonev.Text,
                KolcsonzesDate = dtp_kolcsonzoido.Value,
                Cim = tb_cim.Text,
                Iro = tb_iro.Text,
                Mufaj = cb_mufaj.SelectedItem.ToString(),
            };
            konyvmanager.Insert(konyv);
            bgWorker.RunWorkerAsync();
            MessageBox.Show("Sikeresen hozzáadtál egy kölcsönzőt!");
            tb_olvasojegy.Clear();
            tb_kolcsonzonev.Clear();
            tb_cim.Clear();
            tb_iro.Clear();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int toroltSor = 0;
            foreach (DataGridViewRow selectedRows in dgv_Konyvek.SelectedRows)
            {
                Konyvek torlendo = new Konyvek();
                torlendo.Olvasojegy = selectedRows.Cells["olvasojegy"].Value.ToString();

                toroltSor += konyvmanager.Delete(torlendo);
            }

            MessageBox.Show(string.Format("{0} sor törölve lett", toroltSor));
            if (toroltSor != 0)
            {
                bgWorker.RunWorkerAsync();
            }

        }
        private void InitDataGridView()
        {
            dgv_Konyvek.Rows.Clear();
            dgv_Konyvek.Columns.Clear();
            dgv_Konyvek.AutoGenerateColumns = false;

            DataGridViewColumn OlvasojegyColumn = new DataGridViewColumn()
            {
                Name = "olvasojegy",
                HeaderText = "Olvasojegy",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv_Konyvek.Columns.Add(OlvasojegyColumn);

            DataGridViewColumn NevCoulmn = new DataGridViewColumn()
            {
                Name = "kolcsonzo_nev",
                HeaderText = "Kölcsönző neve",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv_Konyvek.Columns.Add(NevCoulmn);

            DataGridViewColumn IdoCoulmn = new DataGridViewColumn()
            {
                Name = "kolcsonzes_ido",
                HeaderText = "Kölcsönzés ideje",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv_Konyvek.Columns.Add(IdoCoulmn);

            DataGridViewColumn CimCoulmn = new DataGridViewColumn()
            {
                Name = "cim",
                HeaderText = "Cím",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv_Konyvek.Columns.Add(CimCoulmn);

            DataGridViewColumn IroCoulmn = new DataGridViewColumn()
            {
                Name = "iro",
                HeaderText = "Író",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv_Konyvek.Columns.Add(IroCoulmn);

            DataGridViewColumn MufajCoulmn = new DataGridViewColumn()
            {
                Name = "mufaj",
                HeaderText = "Műfaj",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dgv_Konyvek.Columns.Add(MufajCoulmn);

        }

        private void bgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }


        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            konyvekList = konyvmanager.Select();
        }

        private void FillDataGridView()
        {
            DataGridViewRow[] dgw_rows = new DataGridViewRow[konyvekList.Count];

            for (int i = 0; i < konyvekList.Count; i++)
            {
                DataGridViewRow dgw_row = new DataGridViewRow();

                DataGridViewCell OlvasojegyCell = new DataGridViewTextBoxCell();
                OlvasojegyCell.Value = konyvekList[i].Olvasojegy;
                dgw_row.Cells.Add(OlvasojegyCell);

                DataGridViewCell NevCell = new DataGridViewTextBoxCell();
                NevCell.Value = konyvekList[i].KolcsonzoNev;
                dgw_row.Cells.Add(NevCell);

                DataGridViewCell IdoCell = new DataGridViewTextBoxCell();
                IdoCell.Value = konyvekList[i].KolcsonzesDate;
                dgw_row.Cells.Add(IdoCell);

                DataGridViewCell CimCell = new DataGridViewTextBoxCell();
                CimCell.Value = konyvekList[i].Cim;
                dgw_row.Cells.Add(CimCell);

                DataGridViewCell IroCell = new DataGridViewTextBoxCell();
                IroCell.Value = konyvekList[i].Iro;
                dgw_row.Cells.Add(IroCell);

                DataGridViewCell MufajCell = new DataGridViewTextBoxCell();
                MufajCell.Value = konyvekList[i].Mufaj;
                dgw_row.Cells.Add(MufajCell);


                dgw_rows[i] = dgw_row;
            }
            dgv_Konyvek.Rows.Clear();
            dgv_Konyvek.Rows.AddRange(dgw_rows);
        }

         private void tb_olvasojegy_Leave(object sender, EventArgs e)
        {
               string actual = tb_olvasojegy.Text;
                bool correct = konyvmanager.CheckOlvasojegy(actual);
                tb_olvasojegy.BackColor = correct ? Color.White : Color.Yellow;

        } 
    }
}
    
