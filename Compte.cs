using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBinding_Banque
{
    public partial class Compte : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["monCon"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter CompteAdapter;
        SqlDataAdapter ClientAdapter;
        DataSet dataset = new DataSet();
        BindingManagerBase bindingManagerBase;
        bool someThingChanged = false;

        public Compte()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompteAdapter = new SqlDataAdapter("select * from compte;", connection);
            CompteAdapter.Fill(dataset, "compte");
            ClientAdapter = new SqlDataAdapter("select * from client;", connection);
            ClientAdapter.Fill(dataset, "client");

            bindingManagerBase = BindingContext[dataset.Tables["compte"]];

            compteDataGridView.DataSource = dataset.Tables["compte"];
            NumClient.DataSource = dataset.Tables["client"];
            NumClient.DisplayMember = "num_client";
            

            NumCompte.DataBindings.Add("text", dataset.Tables["compte"], "num_compte");
            NumClient.DataBindings.Add("text", dataset.Tables["compte"], "num_client");
            Solde.DataBindings.Add("text", dataset.Tables["compte"], "solde");
            TypeCompte.DataBindings.Add("text", dataset.Tables["compte"], "typeC");

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position++;
        }

        private void precedent_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position--;
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position = 0;
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            bindingManagerBase.Position = bindingManagerBase.Count - 1;
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            bindingManagerBase.AddNew();
            Solde.ReadOnly = false;
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                bindingManagerBase.EndCurrentEdit();
                someThingChanged=true;
                Solde.ReadOnly = true;
                compteDataGridView.Refresh();
                MessageBox.Show("le compte a ete ajoute");
            }catch(Exception ex)
            {
                MessageBox.Show("Er :"+ex.Message);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            bindingManagerBase.EndCurrentEdit();
            MessageBox.Show("le compte a ete modifie");
            someThingChanged = true;
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            bindingManagerBase.RemoveAt(bindingManagerBase.Position);
            MessageBox.Show("suppression a ete effectue");
            someThingChanged = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (someThingChanged)
            {
                DialogResult result = MessageBox.Show("voulez vous sauvgarder les changement", "sauvgarder", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(CompteAdapter);
                        CompteAdapter.Update(dataset.Tables["compte"]);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erreur : "+ex.Message);
                    }
                    
                }
            }

        }
    }
}
