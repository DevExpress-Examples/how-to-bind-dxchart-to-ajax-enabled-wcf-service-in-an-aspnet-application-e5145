using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using DxSample.DAL.BO;

namespace DxSample.DAL
{
    [ServiceContract(Namespace = "DxSample")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DxSampleService
    {
        // This method returns hard coded data for the sake of simplicity
        // In real applications, WCF service operations usually connect to the SQL database and return real data
        [OperationContract, WebGet]
        public Sale[] GetSales()
        {
            return new Sale[] {
                new Sale() {
                    Day = "Monday",
                    OrangesSold = 3
                },
                new Sale() {
                    Day = "Tuesday",
                    OrangesSold = 2
                },
                new Sale() {
                    Day = "Wednesday",
                    OrangesSold = 3
                },
                new Sale() {
                    Day = "Thursday",
                    OrangesSold = 4
                },
                new Sale() {
                    Day = "Friday",
                    OrangesSold = 6
                },
                new Sale() {
                    Day = "Saturday",
                    OrangesSold = 11
                },
                new Sale() {
                    Day = "Sunday",
                    OrangesSold = 4
                }
            };
        }
    }
}
