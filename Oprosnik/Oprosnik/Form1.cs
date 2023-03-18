using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Статичный список объектов person
        public static List<Person> persons;

        public Form1()
        {
            InitializeComponent();
            //Конвертируем содержимое файла в список объектов person
            persons = ConverToPersons("person.json");
            //Чтобы при запуске приложения объекты класса person были отображены в комбобоксе
            foreach (Person person in persons)
            {
                PersonComboBox.Items.Add(person.GetTitle());
            }

        }

        //Скролл бар слушатель
        private void AgeScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            AgeLabel.Text = e.NewValue.ToString();
        }



        //Сохранение ответов
        //Конвертация элементов формы в примитивне типы данных
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
            Person person = new Person(InputName.Text, InputSurname.Text, Convert.ToInt32(InputGroupNumber.Text), questionOneAnswer, FruitsList, questionThreeAnswer, (int)Question4numericUpDown.Value, InterestScrollBar.Value);

            //Добавление в комбобокс со всеми объектами списка persons
            PersonComboBox.Items.Add(person.GetTitle());

            //Добавление глобальный список persons
            persons.Add(person);

            //Записываем его в файл
            File.WriteAllText("person.json", ConvertListToJsonString(persons));


        }

        //Загрузка ответов в groupBox
        //Проходится по каждому объекту в списке персон и если имя в комбобоксе совпадает с Title объекта, то выводит поля объекта
        private void LoadAnswers_Click(object sender, EventArgs e)
        {
            foreach (Person person in persons)
            {
                if (PersonComboBox.Text == person.GetTitle())
                {
                    ShowAnswers(person);
                }
            }

        }

        void ShowAnswers(Person person)
        {
            //Отображение имени и фамилии
            AnswerGroupBox.Text = person.GetTitle();

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
            QuestionAnswer2.Text = RemoveLastChars(QuestionAnswer2.Text, 2);

            //Третий вопрос
            QuestionAnswer3.Text = person.Education;

            //Четвёртый вопрос
            QuestionAnswer4.Text = person.Age.ToString();

            //Пятый вопрос
            QuestionAnswer5.Text = person.EducationInterest.ToString();

            //Сделать окошко с ответами видимым
            AnswerGroupBox.Visible = true;
        }
        //Вспомогательный метод, который удаляет {count} кол-во символов с конца
        public static string RemoveLastChars(string str, int count)
        {
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - count);
                return str;
            }
            else return str;
        }
        //Вписать рандомные ответы
        private void SetRandomAnswers_Click(object sender, EventArgs e)
        {
            InputGroupNumber.Text = new Random().Next(0, 1000).ToString();
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
        //Очистка БД + очистка полей в форме для наглядности
        private void RemoveAnswers_Click(object sender, EventArgs e)
        {
            File.Delete("person.json");
            PersonComboBox.Items.Clear();
            persons.Clear();
            PersonComboBox.Text = "";
            AnswerGroupBox.Visible = false;
        }

        //Конвертировать список объектов в json формат
        //Проходится по каждому объекту в списке persons, конверитрует их в json строку, разъеденяет запятыми и добавляет [] по бокам
        private string ConvertListToJsonString(List<Person> persons)
        {
            string jsonString = "[";
            foreach (Person person in persons)
            {
                jsonString += person.ToJson() + ",";
            }
            jsonString = RemoveLastChars(jsonString, 1);
            jsonString += "]";
            return jsonString;
        }
        //Парсит json строку и возвращает список объектов
        private static List<Person> ConverToPersons(string fileName)
        {
            //Проверка существует ли файл, если нет, то вернёт пустой список
            if (File.Exists(fileName))
            {
                //Создаём объект без полей, в который потом будем вписывать данные
                List<Person> persons = new List<Person>();
                //Считывает данные из файла в строку
                string jsonIputString = File.ReadAllText(fileName);
                //Проходимся по каждому символу в строке и если он равен '{', значит это новый объект и мы его инициализируем
                for (int i = 0; i < jsonIputString.Length; i++)
                {
                    //Инициализация объекта
                    Person person = new Person();

                    if (jsonIputString[i] == '{')
                    {
                        //Текущая позиция проходчика по строке
                        int currentPos = i;
                        //Просто вспомогательные переменные
                        int start = 0;
                        int end = 0;
                        //Флаг, который озночает когда у нас закончились поля для объекта
                        bool breakFlag = false;
                        //Пока не закончились поля, мы их парсим
                        while (!breakFlag)
                        {
                            //Создаём новый список в виде ключ-значение, где первый элемент списка - ключ, второй - значение
                            List<string> key_value = new List<string>();
                            //Ищем вхождение ' " ' в строку и копируем в ключ все символы между первым вхождением в строку ' " ' и вторым
                            start = jsonIputString.IndexOf('"', currentPos);
                            currentPos = start + 1;
                            end = jsonIputString.IndexOf('"', currentPos);
                            //Добавляем скопированную подстроку в ключ
                            key_value.Add(jsonIputString.Substring(start + 1, end - start - 1));
                            currentPos = end + 1;
                            //Находим вхождение ' : ' в строку, копируем все символы до запятой после него, это и будет значение
                            start = jsonIputString.IndexOf(':', currentPos);
                            currentPos = start + 1;
                            //Условие на проверку, не является ли значение массивом, если да, то проходчик ищет не запятую, а конеч массмва
                            if (jsonIputString[currentPos] == '[')
                            {
                                end = jsonIputString.IndexOf(']', currentPos) + 1;
                            }
                            else
                            {

                                end = jsonIputString.IndexOf(',', currentPos);
                                //Если проходчик не нашёл запятую, значит это коннец json файла, и для конца значния мы ищем не запятую, а ' } '
                                if (end == -1)
                                {
                                    end = jsonIputString.IndexOf('}', currentPos);
                                    breakFlag = true;
                                }
                                //Иначе, если он нашёл запятую, но перед запятой был ' } ', это значит, что это конец объекта, но не всего массива объектов
                                else if (jsonIputString[end - 1] == '}')
                                {
                                    end -= 1;
                                    breakFlag = true;
                                }

                            }
                            //Добавляем значение в список ключ-значение
                            key_value.Add(jsonIputString.Substring(start + 1, end - start - 1));
                            currentPos = end + 1;
                            //Проверяем, что за ключ мы получили и по нему присваеваем значение объекту
                            switch (key_value[0])
                            {
                                case "FirstName":
                                    //Сабстринг нужен, чтобы в значение не присваивалось значение в скобках
                                    person.FirstName = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "LastName":
                                    person.LastName = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "GroupNumber":
                                    person.GroupNumber = Convert.ToInt32(key_value[1]);
                                    break;
                                case "Icecream":
                                    person.Icecream = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "Fruits":
                                    //Конвертация string массива в обычный
                                    key_value[1] = key_value[1].Remove(key_value[1].Length - 1, 1).Remove(0, 1);
                                    List<string> fruitsList = new List<string>();
                                    foreach (string fruit in key_value[1].Split(','))
                                    {
                                        fruitsList.Add(fruit.Remove(fruit.Length - 1, 1).Remove(0, 1));
                                    }
                                    person.Fruits = fruitsList;
                                    break;
                                case "Education":
                                    person.Education = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "Age":
                                    person.Age = Convert.ToInt32(key_value[1]);
                                    break;
                                case "EducationInterest":
                                    person.EducationInterest = Convert.ToInt32(key_value[1]);
                                    break;

                            }
                        }
                        //Добавляем в список persons person
                        persons.Add(person);
                    }

                }
                return persons;
            }
            else
            {
                return new List<Person>();
            }
        }
    }
}
