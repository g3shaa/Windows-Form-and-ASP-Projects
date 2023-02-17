using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculator
{
    public partial class Form1 : Form
    {
        // Дефинираме променливи за калориите на всяка храна
        int burgerCalories = 500;
        int friesCalories = 350;
        int sodaCalories = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Инициализираме променливата за общия брой на калориите
            int totalCalories = 0;

            // Проверяваме дали текстовите полета са попълнени и ги преобразуваме в целочислени стойности
            if (!string.IsNullOrEmpty(burgerTextBox.Text))
            {
                int burgerQuantity = int.Parse(burgerTextBox.Text);
                totalCalories += burgerQuantity * burgerCalories;
            }

            if (!string.IsNullOrEmpty(friesTextBox.Text))
            {
                int friesQuantity = int.Parse(friesTextBox.Text);
                totalCalories += friesQuantity * friesCalories;
            }

            if (!string.IsNullOrEmpty(sodaTextBox.Text))
            {
                int sodaQuantity = int.Parse(sodaTextBox.Text);
                totalCalories += sodaQuantity * sodaCalories;
            }

            // Показваме общия брой на калориите в лейбъла
            totalCaloriesLabel.Text = "Общо калориите са " + totalCalories.ToString();
        }
    }
}