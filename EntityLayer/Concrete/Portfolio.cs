using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioImageUrl { get; set; }
        public string PortfolioProjectUrl { get; set; }
        public string PortfolioImageUrl2 { get; set; }
        public string PortfolioPlatform { get; set; }
        public string PortfolioFee { get; set; }
        public bool PortfolioStatus { get; set; }
        public string PortfolioImg1 { get; set; }
        public string PortfolioImg2 { get; set; }
        public string PortfolioImg3 { get; set; }
        public string PortfolioImg4 { get; set; }
        public int PortfolioValue { get; set; }
    }
}
