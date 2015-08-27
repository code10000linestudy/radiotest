using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using RadioDb.Models;

namespace RadioDb.Repository
{
    public class SurveyQuetionRepository
    {
        #region [ SingleTon ]
        public static SurveyQuetionRepository Instance { get; private set; }

        static SurveyQuetionRepository()
        {
            Instance = new SurveyQuetionRepository();
        }
        #endregion

        private CloudStorageAccount storageAccount;
        private CloudTableClient tableClient;
        private CloudTable table;

        public SurveyQuetionRepository()
        {
            // github에 올리기 위해 코드를 임시로 변경
            // key값도 삭제함
            //string key =
            //    ConfigurationManager.ConnectionStrings["AzuteTableSurveyMVC.Properties.Settings.StorageConnectionString"].ToString();
            //storageAccount = CloudStorageAccount.Parse(key);

            //// Create the table client.
            //tableClient = storageAccount.CreateCloudTableClient();

            //// Create the table if it doesn't exist.
            //table = tableClient.GetTableReference(SurveyQuestion.TableName);
            //table.CreateIfNotExists();
        }

        public Task<IEnumerable<SurveyQuestion>> Read(long readKey)
        {
            // Dummy 값 출력
            var list = new List<SurveyQuestion>
            {
                new SurveyQuestion
                {
                    QuestionType = SurveyQuestion.QuestionTypes.Main,
                    PartitionKey = "001",
                    RowKey = "main",
                    Index = 0,
                    Header = "질문 헤더",
                    Description = "질문 설명\n블라블라\n블라블라",
                },
                new SurveyQuestion
                {
                    QuestionType = SurveyQuestion.QuestionTypes.Object,
                    PartitionKey = "001",
                    RowKey = "001",
                    Index = 1,
                    Header = "질문 헤더",
                    Description = "질문 설명\n블라블라\n블라블라",
                    ObjectAnswer1 = "답변1",
                    ObjectAnswer2 = "답변2",
                    ObjectAnswer3 = "답변3",
                    ObjectAnswer4 = "답변4",
                    ObjectAnswer5 = "답변5",
                },
                new SurveyQuestion
                {
                    QuestionType = SurveyQuestion.QuestionTypes.Object,
                    PartitionKey = "001",
                    RowKey = "001",
                    Index = 2,
                    Header = "질문 헤더",
                    Description = "질문 설명\n블라블라\n블라블라",
                    ObjectAnswer1 = "답변1",
                    ObjectAnswer2 = "답변2",
                    ObjectAnswer3 = "답변3",
                    ObjectAnswer4 = "답변4",
                    ObjectAnswer5 = "답변5",
                },
                new SurveyQuestion
                {
                    QuestionType = SurveyQuestion.QuestionTypes.Subject,
                    PartitionKey = "001",
                    RowKey = "002",
                    Index = 3,
                    Header = "질문 헤더",
                    Description = "질문 설명\n블라블라\n블라블라",
                },
                new SurveyQuestion
                {
                    QuestionType = SurveyQuestion.QuestionTypes.CheckBox,
                    PartitionKey = "001",
                    RowKey = "003",
                    Index = 4,
                    Header = "질문 헤더",
                    Description = "질문 설명\n블라블라\n블라블라",
                    CheckBoxAnswer1 = "체크1",
                    CheckBoxAnswer2 = "체크2",
                    CheckBoxAnswer3 = "체크3",
                    CheckBoxAnswer4 = "체크4",
                    CheckBoxAnswer5 = "체크5",
                    CheckBoxAnswer6 = "체크6",
                    CheckBoxAnswer7 = "체크7",
                }
            };

            return Task.FromResult((IEnumerable<SurveyQuestion>) list);
        } 
    }
}
