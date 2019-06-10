using System;
using System.Collections.Generic;
using System.Text;
using IAC;
namespace LektuvuRegistravimasBL
{
    public class HTMLGenerator
    {
        public string GenerateHTMLWithColor(List<ReportItem> ataskaita)
        {
            string HTML_DOC_FORMAT = "<html>" +
  "< head >" +
    "< style >" +
      "table, th, td {" +
            "border: 1px solid black;" +
                "border - collapse: collapse;" +
            "padding: 5px;" +
            "}" +
    "</ style >" +
  "</ head >" +
  "< body >" +
    "% s" +
    "% s" +
  "</ body >" +
"</ html >";

string HTML_TABLE_FORMAT = "< table >" +
  "< caption >% s </ caption >" +
  "< tr >" +
    "< th > TAIL_NUMBER </ th >" +
    "< th > MODEL_NUMBER </ th >" +
    "< th > MODEL_DESCRIPTION </ th >" +
    "< th > OWNER_COMPANY_NAME </ th >" +
    "< th > COMPANY_COUNTRY_CODE </ th >" +
    "< th > COMPANY_COUNTRY_NAME </ th >" +
  "</ tr >" +
  "% s" +
"</ table >";


string HTML_TABLE_ROW_FORMAT_EU = "< tr style = 'background-color:%s'>" +
   "< td >% s </ td >" +
   "< td >% s </ td >" +
   "< td >% s </ td >" +
   "< td >% s </ td >" +
   "< td >% s </ td >" +
   "< td >% s </ td >" +
 "</ tr >";
            string HTML_TABLE_ROW_FORMAT_NON_EU = "< tr >" +
              "< td >% s </ td >" +
              "< td >% s </ td >" +
              "< td >% s </ td >" +
              "< td >% s </ td >" +
              "< td >% s </ td >" +
              "< td >% s </ td >" +
            "</ tr >";
            string htmlAllCode = HTML_DOC_FORMAT + HTML_TABLE_FORMAT + HTML_TABLE_ROW_FORMAT_EU + HTML_TABLE_ROW_FORMAT_NON_EU;
            //Console.WriteLine(htmlAllCode);
            return htmlAllCode;
        }
    }
}
