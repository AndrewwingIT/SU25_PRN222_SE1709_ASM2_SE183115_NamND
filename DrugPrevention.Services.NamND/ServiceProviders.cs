using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugPrevention.Services.NamND
{
    public interface IServiceProviders
    {
        System_UserAccountService System_UserAccountService { get; }
        SurveyQuestionsNamNDService SurveyQuestionsNamNDService { get; }
        SurveysNamNDService SurveysNamNDService { get; }
        ISurveyQuestionsNamNDService SurveyQuestionsNamNDServiceInterface { get; }
    }

    public class ServiceProviders : IServiceProviders
    {
        private System_UserAccountService _systemUserAccountService;
        private SurveyQuestionsNamNDService _surveyQuestionsNamNDService;
        private SurveysNamNDService _surveysNamNDService;
        private ISurveyQuestionsNamNDService _surveyQuestionsNamNDServiceInterface;

        public System_UserAccountService System_UserAccountService
        {
            get { return _systemUserAccountService ??= new System_UserAccountService(); }
        }

        public SurveyQuestionsNamNDService SurveyQuestionsNamNDService
        {
            get { return _surveyQuestionsNamNDService ??= new SurveyQuestionsNamNDService(); }
        }

        public SurveysNamNDService SurveysNamNDService
        {
            get { return _surveysNamNDService ??= new SurveysNamNDService(); }
        }

        public ISurveyQuestionsNamNDService SurveyQuestionsNamNDServiceInterface
        {
            get { return _surveyQuestionsNamNDServiceInterface ??= new SurveyQuestionsNamNDService(); }
        }
    }
}
