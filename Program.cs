using System;
using System.Text.RegularExpressions;

namespace readFile
{
    class Program
    {
        static void Main(string[] args){
            // works but don't need to download file again
            // have to use this method of getting a new webclient instead, in older versions
            var wc = new System.Net.WebClient();
            string remoteUri = "http://ringba-test-html.s3-website-us-west-1.amazonaws.com/TestQuestions/";
            string fileName = "output.txt", myStringWebResource = null;
            // Create a new WebClient instance.
            //WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            wc.DownloadFile(myStringWebResource,fileName);		
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + "Application.StartupPath");
            Console.WriteLine("New code below");
            Regex rx = new Regex(@"m|M",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            string text = "MelancholicMelancholicallyMelancholinessMelanilinMelanorrhoeaMelanosisMeletskiMeliaceaeMelibioseMelicrateMeliorabilityMelissaMelithemiaMellifluentlyMellisonantMellowyMellsMelodeonsMelodizesMelodizingMelodramaticsMelodramatistsMelodramatizationMelolonthidaeMelonMelosMelotropeMelungeonMembranogenicMemnonMemnoniumMemorializesMenacinglyPeltatePeltigeraceaePemolinePemphigousPenaeaceaePenalPenalistPenallyPenancingPenbardPenciliformPencraftPenetrablyPenetrologyPenetrolqgyPenicillationPeninsularismPenitencyPenitentiariesPennaceousPennatularianPenneyPennyPennillPennyroyalsPenologiesPensilsPentacetatePentacrosticPentametersPentaphylaxPentastichousPentastomumPentasulphidePentateuchalPentelicanPentosidePentremitePenumbraPenwomanshipPephredoPepperishPepsPepsinhydrochloricPepsiniferousPeracidsPeracutePerambulatesPerambulatorsPerceivablePerceivedlyPerceiversPercentablePerchlorinatingPercolable";

            MatchCollection matches = rx.Matches(text);

            Console.WriteLine("{0} matches found in:\n   {1}",
                          matches.Count,
                          text);
          
        }
    } 
} 




