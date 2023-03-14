using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //Чтобы при запуске приложения список из файла считывался
            foreach (Person person in persons)
            {
                PersonComboBox.Items.Add(person.FirstName + " " + person.LastName + " " + person.GroupNumber);
            }
        }
        //Скролл бар слушатель
        private void AgeScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            AgeLabel.Text = e.NewValue.ToString();
        }

        //Если файл существует, то считать оттуда список, если нет, то создать новый
        static List<Person> persons = File.Exists("person.json") ? JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("person.json")) : new List<Person>();

        //Сохранение ответов
        private void SaveAnswersButton_Click(object sender, EventArgs e)
        {
            string questionOneAnswer = "";
            string questionThreeAnswer = "";
            
            //Обработка первого вопроса
            RadioButton[] questionOneOptions = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };
            foreach (RadioButton option in questionOneOptions)
            {
                if (option.Checked)
                {
                    questionOneAnswer = option.Text;
                }
            }

            List<string> FruitsList = new List<string>();

            CheckBox[] questionTwoOptions = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            foreach (CheckBox option in questionTwoOptions)
            {
                if (option.Checked)
                {
                    FruitsList.Add(option.Text);
                }
            }

            //Обработка третьего вопроса
            if (Question3ComboBox.SelectedItem != null)
            {
                questionThreeAnswer = Question3ComboBox.SelectedItem.ToString();
            }

            //Создание объекта person
            Person person = new Person(InputName.Text, InputSurname.Text, InputGroupNumber.Text, questionOneAnswer, FruitsList, questionThreeAnswer, (int)Question4numericUpDown.Value, InterestScrollBar.Value);

            //Добавление в комбобокс
            PersonComboBox.Items.Add(person.FirstName + " " + person.LastName + " " + person.GroupNumber);

            //Добавление глобальный список persons
            persons.Add(person);

            //Сериализируем список
            string json = JsonConvert.SerializeObject(persons, Formatting.Indented);

            //Записываем его в файл
            File.WriteAllText("person.json", json);


        }

        //Загрузка ответов в бокс
        private void LoadAnswers_Click(object sender, EventArgs e)
        {
            foreach (Person person in persons)
            {
                if (PersonComboBox.Text == person.FirstName + " " + person.LastName + " " + person.GroupNumber)
                {
                    ShowAnswers(person);
                }
            }

        }

        void ShowAnswers(Person person)
        {
            //Отображение имени и фамилии
            AnswerGroupBox.Text = person.FirstName + " " + person.LastName + " " + person.GroupNumber;

            //Отображение ответов на вопросы

            //Первый вопрос
            QuestionAnswer1.Text = person.Icecream;


            //Второй вопрос
            //Строчка чтобы при повторном сохранении ответов не было бесконечного добавления
            QuestionAnswer2.Text = "";
            foreach (string answer in person.Fruits)
            {
                QuestionAnswer2.Text += answer + ", ";
            }

            //Удалям последнюю ненужную запятую
            if (QuestionAnswer2.Text.Length > 0)
            {
                QuestionAnswer2.Text = QuestionAnswer2.Text.Remove(QuestionAnswer2.Text.Length - 2);
            }

            //Третий вопрос
            QuestionAnswer3.Text = person.Education;

            //Четвёртый вопрос
            QuestionAnswer4.Text = person.Age.ToString();

            //Пятый вопрос
            QuestionAnswer5.Text = person.EducationInterest.ToString();

            //Сделать окошко с ответами видимым
            AnswerGroupBox.Visible = true;
        }

        private void SetRandomAnswers_Click(object sender, EventArgs e)
        {

            InputGroupNumber.Text = new Random().Next(0,1000).ToString();
            InputName.Text = "Василий";
            InputSurname.Text = "Смагин";
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            Question3ComboBox.SelectedIndex = 4;
            Question4numericUpDown.Value = 25;
            AgeLabel.Text = "100";
            InterestScrollBar.Value = 100;
        }


    }
}
