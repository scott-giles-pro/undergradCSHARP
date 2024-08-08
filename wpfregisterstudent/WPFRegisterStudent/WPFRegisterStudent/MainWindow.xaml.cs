﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");

            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);
            
            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);
            if (listBox.Items.Contains(choice))
            {
                this.label3.Content = "You are already registered for this course.";
                int credits = listBox.Items.Count * 3;
                this.textBox.Text = Convert.ToString(credits);
            }
            else
            {
                int credits = listBox.Items.Count * 3;
                if (credits >= 9)
                {
                    this.label3.Content = "You cannot register for more than nine credits in a term.";
                    this.textBox.Text = Convert.ToString(credits);
                }
                else
                {
                    this.label3.Content = "You are now registered for this course.";
                    this.listBox.Items.Add(choice);
                    credits = listBox.Items.Count * 3;
                    this.textBox.Text = Convert.ToString(credits);
                }
            }
        }
    }
}