using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace BelieveOrNotBelieve2
{

    public delegate void ChangedName(string filename);

    //Класс для вопроса    
   
    
    public class Question
    {        
        public string text { get; set; }//Текст вопроса
        public bool trueFalse { get; set; }//Правда или нет
        //Вообще-то мы здесь нарушаем правила инкапсуляции и эти поля нужно было бы реализовать
        //через открытые свойства, но для упрощения примера оставим так
        //Вам же предлагается сделать поля закрытыми и реализовать открыте свойства Text и TrueFalse

        //Для сериализации должен быть пустой конструктор.
        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }        
    }

    

    //Класс для хранения списка вопросов. А так же для сериализации в XML и десериализации из XML
    public class BelieveOrNotBelive
    {

        static public event ChangedName changeName;
        string fileName;
        List<Question> list;



        public string FileName
        {
            set {
                fileName = value;
                changeName?.Invoke(fileName);
            }
        }

        public BelieveOrNotBelive(string fileName)
        {           
            this.fileName = fileName;
            changeName?.Invoke(fileName);
            list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            list.RemoveAt(index);
        }

        //Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get {
                if (list != null && index >= 0 && index < list.Count)
                    return list[index];
                else throw new IndexOutOfRangeException("Выход за пределы списка вопросов");
            }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public List<Question> List
        {
            get { return list; }
            //set { list = value; }
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
