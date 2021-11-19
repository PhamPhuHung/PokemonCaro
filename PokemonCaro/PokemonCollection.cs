using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCaro
{
    public partial class PokemonCollection : Form
    {
        #region Properties
        private List<List<Button>> pokeballList;
        private List<List<PictureBox>> pbPokeballList;

        public List<List<Button>> PokeballList { get => pokeballList; set => pokeballList = value; }
        public List<List<PictureBox>> PbPokeballList { get => pbPokeballList; set => pbPokeballList = value; }

        int currentGen = 0;
        #endregion

        public PokemonCollection()
        {
            InitializeComponent();
        }



        private void btLeftGen_Click(object sender, EventArgs e)
        {
            currentGen--;
            if (currentGen < 0)
            {
                currentGen = 0;
                return;
            }
            ShowCollection(currentGen);

        }

        private void btRightGen_Click(object sender, EventArgs e)
        {
            currentGen++;
            if (currentGen >= PbPokeballList.Count())
            {
                currentGen = PbPokeballList.Count() - 1;
                return;
            }
            ShowCollection(currentGen);
        }

        private void PokemonCollection_Shown(object sender, EventArgs e)
        {
            LoadCollection();
            ShowCollection(currentGen);
        }

        private void LoadCollection()
        {
            PbPokeballList = new List<List<PictureBox>>();

            for(int i = 0;i<PokeballList.Count();i++)
            {
                PbPokeballList.Add(new List<PictureBox>());
                for (int j = 0; j < Constant.POKEMON_QUANTITY_PER_GENERATION; j++)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Size = new Size(125, 125),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        ImageLocation = PokeballList[i][j].AccessibleDescription
                    };
                    PbPokeballList[i].Add(pb);
                }
            }
        }

        private void ShowCollection(int genNumber)
        {
            flpCollection.Controls.Clear();
            flpCollection.Controls.AddRange(PbPokeballList[genNumber].ToArray());
            lbGen.Text = Constant.GENERATION[genNumber];
        }
    }
}
