using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Vocab_Trainer
{
    public partial class MainForm : Form
    {
        Database_New db_new;
        Setup_Form setup;
        Random rand = new Random();
        int id = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainTexts()
        {

            if (deutschToolStripMenuItem1.Checked && deutschToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Deutsch->Deutsch";
                lblOriginLanguage.Text = "deutsch";
                lblTargetLanguage.Text = "deutsch";
            }
            if (deutschToolStripMenuItem1.Checked && englischToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Deutsch->Englisch";
                lblOriginLanguage.Text = "deutsch";
                lblTargetLanguage.Text = "english";
            }
            if (deutschToolStripMenuItem1.Checked && spanischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Deutsch->Spanisch";
                lblOriginLanguage.Text = "deutsch";
                lblTargetLanguage.Text = "espanol";
            }
            if (deutschToolStripMenuItem1.Checked && italienischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Deutsch->Italienisch";
                lblOriginLanguage.Text = "deutsch";
                lblTargetLanguage.Text = "italiano";
            }
            if (deutschToolStripMenuItem1.Checked && schwedischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Deutsch->Schwedisch";
                lblOriginLanguage.Text = "deutsch";
                lblTargetLanguage.Text = "svenska";
            }
            if (englischToolStripMenuItem1.Checked && deutschToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "English->German";
                lblOriginLanguage.Text = "english";
                lblTargetLanguage.Text = "deutsch";
            }
            if (englischToolStripMenuItem1.Checked && englischToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "English->English";
                lblOriginLanguage.Text = "english";
                lblTargetLanguage.Text = "english";
            }
            if (englischToolStripMenuItem1.Checked && spanischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "English->Spanish";
                lblOriginLanguage.Text = "english";
                lblTargetLanguage.Text = "espanol";
            }
            if (englischToolStripMenuItem1.Checked && italienischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "English->Italian";
                lblOriginLanguage.Text = "english";
                lblTargetLanguage.Text = "italiano";
            }
            if (englischToolStripMenuItem1.Checked && schwedischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "English->Swedish";
                lblOriginLanguage.Text = "english";
                lblTargetLanguage.Text = "svenska";
            }
            if (italienischToolStripMenuItem.Checked && deutschToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Italiano->Tedesco";
                lblOriginLanguage.Text = "italiano";
                lblTargetLanguage.Text = "deutsch";
            }
            if (italienischToolStripMenuItem.Checked && englischToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Italiano->Inglese";
                lblOriginLanguage.Text = "italiano";
                lblTargetLanguage.Text = "english";
            }
            if (italienischToolStripMenuItem.Checked && spanischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Italiano->Spagnolo";
                lblOriginLanguage.Text = "italiano";
                lblTargetLanguage.Text = "espanol";
            }
            if (italienischToolStripMenuItem.Checked && schwedischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Italiano->Svedese";
                lblOriginLanguage.Text = "italiano";
                lblTargetLanguage.Text = "svenska";
            }
            if (italienischToolStripMenuItem.Checked && italienischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Italiano->Italiano";
                lblOriginLanguage.Text = "italiano";
                lblTargetLanguage.Text = "italiano";
            }
            if (spanischToolStripMenuItem.Checked && englischToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Espanol->Ingles";
                lblOriginLanguage.Text = "espanol";
                lblTargetLanguage.Text = "english";
            }
            if (spanischToolStripMenuItem.Checked && deutschToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Espanol->Aleman";
                lblOriginLanguage.Text = "espanol";
                lblTargetLanguage.Text = "deutsch";
            }
            if (spanischToolStripMenuItem.Checked && spanischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Espanol->Espanol";
                lblOriginLanguage.Text = "espanol";
                lblTargetLanguage.Text = "espanol";
            }
            if (spanischToolStripMenuItem.Checked && italienischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Espanol->Italiano";
                lblOriginLanguage.Text = "espanol";
                lblTargetLanguage.Text = "italiano";
            }
            if (spanischToolStripMenuItem.Checked && schwedischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Espanol->Sueco";
                lblOriginLanguage.Text = "espanol";
                lblTargetLanguage.Text = "svenska";
            }
            if (schwedischToolStripMenuItem.Checked && deutschToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Svenska->Tysk";
                lblOriginLanguage.Text = "svenska";
                lblTargetLanguage.Text = "deutsch";
            }
            if (schwedischToolStripMenuItem.Checked && englischToolStripMenuItem2.Checked)
            {
                lblLanguage.Text = "Svenska->Engelsk";
                lblOriginLanguage.Text = "svenska";
                lblTargetLanguage.Text = "english";
            }
            if (schwedischToolStripMenuItem.Checked && spanischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Svenska->Spanska";
                lblOriginLanguage.Text = "svenska";
                lblTargetLanguage.Text = "espanol";
            }
            if (schwedischToolStripMenuItem.Checked && italienischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Svenska->Italianska";
                lblOriginLanguage.Text = "svenska";
                lblTargetLanguage.Text = "italiano";
            }
            if (schwedischToolStripMenuItem.Checked && schwedischToolStripMenuItem1.Checked)
            {
                lblLanguage.Text = "Svenska->Svenska";
                lblOriginLanguage.Text = "svenska";
                lblTargetLanguage.Text = "svenska";
            }
        }

        private void übersetzungErgänzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datenbankHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(db_new == null)
            {
                db_new = new Database_New();
                db_new.MdiParent = this;
                db_new.WindowState = FormWindowState.Maximized;
                db_new.Show();
                db_new.FormClosed += new FormClosedEventHandler(Database_New_FormClosed);
            }
        }

        private void Database_New_FormClosed(object sender, EventArgs e)
        {
            db_new = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.input) == false)
            {
                setup = new Setup_Form();
                setup.ShowDialog();
                this.Close();
            }
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mySQLSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (setup == null)
            {
                setup = new Setup_Form();
                setup.MdiParent = this;
                setup.WindowState = FormWindowState.Maximized;
                setup.Show();
                setup.FormClosed += new FormClosedEventHandler(Setup_FormClosed);
            }
        }
        private void Setup_FormClosed(object sender, EventArgs e)
        {
            setup = null;
        }

        private void deutschToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (englishToolStripMenuItem.Checked)
            {
                englishToolStripMenuItem.Checked = false;
            }
            else
            if (espanolToolStripMenuItem.Checked)
            {
                espanolToolStripMenuItem.Checked = false;
            }
            else
            if (italianoToolStripMenuItem.Checked)
            {
                italianoToolStripMenuItem.Checked = false;
            }
            else
            if (svenskaToolStripMenuItem.Checked)
            {
                svenskaToolStripMenuItem.Checked = false;
            }
            deutschToolStripMenuItem3.Checked = true;

            deutschToolStripMenuItem1.Text = "deutsch";
            deutschToolStripMenuItem2.Text = "deutsch";
            englischToolStripMenuItem1.Text = "englisch";
            englischToolStripMenuItem2.Text = "englisch";
            spanischToolStripMenuItem.Text = "spanisch";
            spanischToolStripMenuItem1.Text = "spanisch";
            italienischToolStripMenuItem.Text = "italienisch";
            italienischToolStripMenuItem1.Text = "italienisch";
            schwedischToolStripMenuItem.Text = "schwedisch";
            schwedischToolStripMenuItem1.Text = "schwedisch";
            allgemeinToolStripMenuItem.Text = "allgemein";
            allgemeinToolStripMenuItem1.Text = "allgemein";
            kategorienToolStripMenuItem.Text = "Kategorien";
            sprachenToolStripMenuItem.Text = "Sprachen";
            alleToolStripMenuItem.Text = "alle";
            freizeitToolStripMenuItem.Text = "Freizeit";
            freizeitUndReisenToolStripMenuItem.Text = "Reisen";
            leichtToolStripMenuItem.Text = "Fortgeschritten";
            materialienToolStripMenuItem.Text = "Materialien";
            menschUndTierToolStripMenuItem.Text = "Mensch und Tier";
            nativeToolStripMenuItem.Text = "Native";
            mySQLSetupToolStripMenuItem.Text = "MySQL-Setup";
            naturToolStripMenuItem.Text = "Kleidung";
            personenbezogeneAdjToolStripMenuItem.Text = "personenbezogene Adj.";
            profiToolStripMenuItem.Text = "Profi";
            programmBeendenToolStripMenuItem.Text = "Programm beenden";
            schwierigkeitsgradToolStripMenuItem.Text = "Schwierigkeitsgrad";
            sehrLeichtToolStripMenuItem.Text = "Basics";
            verbenToolStripMenuItem.Text = "Sonstige Verben";
            wetterToolStripMenuItem.Text = "Wetter";
            zahlenToolStripMenuItem.Text = "Zahlen";
            zeitToolStripMenuItem.Text = "Zeit";
            deutschToolStripMenuItem.Text = "Gegeben";
            englischToolStripMenuItem.Text = "Gesucht";
            menüspracheToolStripMenuItem.Text = "Menüsprache";
            typenToolStripMenuItem.Text = "Themenbereiche";
            übersetzungErgänzenToolStripMenuItem.Text = "Übersetzung ergänzen";
            datenbankHinzufügenToolStripMenuItem.Text = "Datenbank hinzufügen";
            stadtToolStripMenuItem.Text = "zu Hause";
            smalltalkToolStripMenuItem.Text = "Phrasen";
            essenUndTrinkenToolStripMenuItem.Text = "Essen und Trinken";
            emotionenToolStripMenuItem.Text = "Emotionen";
            sonstigeAdjektiveToolStripMenuItem.Text = "Sonstige Adjektive";
            sonstigeNomenToolStripMenuItem.Text = "Sonstige Nomen";

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: " + sehrLeichtToolStripMenuItem.Text;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: " + leichtToolStripMenuItem.Text;
            }
            if (profiToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad " + profiToolStripMenuItem.Text;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: " + nativeToolStripMenuItem.Text;
            }
            if (alleToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: " + alleToolStripMenuItem.Text;
            }
            if (zeitToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + zeitToolStripMenuItem.Text;
            }
            if (allgemeinToolStripMenuItem1.Checked)
            {
                lblCategory.Text = "Kategorie: " + allgemeinToolStripMenuItem1.Text;
            }
            if (zahlenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + zahlenToolStripMenuItem.Text;
            }
            if (naturToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + naturToolStripMenuItem.Text;
            }
            if (emotionenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + emotionenToolStripMenuItem.Text;
            }
            if (sonstigeAdjektiveToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + sonstigeAdjektiveToolStripMenuItem.Text;
            }
            if (stadtToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + stadtToolStripMenuItem.Text;
            }
            if (smalltalkToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + smalltalkToolStripMenuItem.Text;
            }
            if (essenUndTrinkenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + essenUndTrinkenToolStripMenuItem.Text;
            }
            if (sonstigeNomenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + sonstigeNomenToolStripMenuItem.Text;
            }
            if (wetterToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorie: " + wetterToolStripMenuItem.Text;
            }
            cmdCheckWord.Text = "Kontrollieren";
            lblOutput.Text = "Ausgabe: ";
            cmdNewWord.Text = "Neues Wort";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem3.Checked)
            {
                deutschToolStripMenuItem3.Checked = false;
            }
            else
            if (espanolToolStripMenuItem.Checked)
            {
                espanolToolStripMenuItem.Checked = false;
            }
            else
            if (italianoToolStripMenuItem.Checked)
            {
                italianoToolStripMenuItem.Checked = false;
            }
            else
            if (svenskaToolStripMenuItem.Checked)
            {
                svenskaToolStripMenuItem.Checked = false;
            }
            englishToolStripMenuItem.Checked = true;

            deutschToolStripMenuItem1.Text = "german";
            deutschToolStripMenuItem2.Text = "german";
            englischToolStripMenuItem1.Text = "english";
            englischToolStripMenuItem2.Text = "english";
            spanischToolStripMenuItem.Text = "spanish";
            spanischToolStripMenuItem1.Text = "spanish";
            italienischToolStripMenuItem.Text = "italian";
            italienischToolStripMenuItem1.Text = "italian";
            schwedischToolStripMenuItem.Text = "swedish";
            schwedischToolStripMenuItem1.Text = "swedish";
            allgemeinToolStripMenuItem.Text = "general";
            allgemeinToolStripMenuItem1.Text = "general";
            kategorienToolStripMenuItem.Text = "categories";
            sprachenToolStripMenuItem.Text = "languages";
            alleToolStripMenuItem.Text = "all";
            freizeitToolStripMenuItem.Text = "free time";
            freizeitUndReisenToolStripMenuItem.Text = "travel";
            leichtToolStripMenuItem.Text = "advanced";
            materialienToolStripMenuItem.Text = "materials";
            menschUndTierToolStripMenuItem.Text = "humans and animals";
            nativeToolStripMenuItem.Text = "native";
            mySQLSetupToolStripMenuItem.Text = "MySQL-setup";
            naturToolStripMenuItem.Text = "clothes";
            personenbezogeneAdjToolStripMenuItem.Text = "personal adjectives";
            profiToolStripMenuItem.Text = "expert";
            programmBeendenToolStripMenuItem.Text = "exit program";
            schwierigkeitsgradToolStripMenuItem.Text = "difficulty";
            sehrLeichtToolStripMenuItem.Text = "basics";
            verbenToolStripMenuItem.Text = "other verbs";
            wetterToolStripMenuItem.Text = "weather";
            zahlenToolStripMenuItem.Text = "numbers";
            zeitToolStripMenuItem.Text = "time";
            deutschToolStripMenuItem.Text = "given";
            englischToolStripMenuItem.Text = "targeted";
            menüspracheToolStripMenuItem.Text = "menu language";
            typenToolStripMenuItem.Text = "topics";
            übersetzungErgänzenToolStripMenuItem.Text = "add translation";
            datenbankHinzufügenToolStripMenuItem.Text = "add database";
            stadtToolStripMenuItem.Text = "at home";
            smalltalkToolStripMenuItem.Text = "phrases";
            essenUndTrinkenToolStripMenuItem.Text = "eat and drink";
            emotionenToolStripMenuItem.Text = "emotions";
            sonstigeAdjektiveToolStripMenuItem.Text = "other adjectives";
            sonstigeNomenToolStripMenuItem.Text = "other nouns";

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: " + sehrLeichtToolStripMenuItem.Text;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: " + leichtToolStripMenuItem.Text;
            }
            if (profiToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty " + profiToolStripMenuItem.Text;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: " + nativeToolStripMenuItem.Text;
            }
            if (alleToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: " + alleToolStripMenuItem.Text;
            }
            if (zeitToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + zeitToolStripMenuItem.Text;
            }
            if (allgemeinToolStripMenuItem1.Checked)
            {
                lblCategory.Text = "Category: " + allgemeinToolStripMenuItem1.Text;
            }
            if (zahlenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + zahlenToolStripMenuItem.Text;
            }
            if (naturToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + naturToolStripMenuItem.Text;
            }
            if (emotionenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + emotionenToolStripMenuItem.Text;
            }
            if (sonstigeAdjektiveToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + sonstigeAdjektiveToolStripMenuItem.Text;
            }
            if (stadtToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + stadtToolStripMenuItem.Text;
            }
            if (smalltalkToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + smalltalkToolStripMenuItem.Text;
            }
            if (essenUndTrinkenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + essenUndTrinkenToolStripMenuItem.Text;
            }
            if (sonstigeNomenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + sonstigeNomenToolStripMenuItem.Text;
            }
            if (wetterToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Category: " + wetterToolStripMenuItem.Text;
            }
            cmdCheckWord.Text = "Check";
            lblOutput.Text = "output: ";
            cmdNewWord.Text = "New word";
        }

        private void italianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem3.Checked)
            {
                deutschToolStripMenuItem3.Checked = false;
            }
            else
            if (espanolToolStripMenuItem.Checked)
            {
                espanolToolStripMenuItem.Checked = false;
            }
            else
            if (englishToolStripMenuItem.Checked)
            {
                englishToolStripMenuItem.Checked = false;
            }
            else
            if (svenskaToolStripMenuItem.Checked)
            {
                svenskaToolStripMenuItem.Checked = false;
            }
            italianoToolStripMenuItem.Checked = true;

            deutschToolStripMenuItem1.Text = "tedesco";
            deutschToolStripMenuItem2.Text = "tedesco";
            englischToolStripMenuItem1.Text = "inglese";
            englischToolStripMenuItem2.Text = "inglese";
            spanischToolStripMenuItem.Text = "spagnolo";
            spanischToolStripMenuItem1.Text = "spagnolo";
            italienischToolStripMenuItem.Text = "italiano";
            italienischToolStripMenuItem1.Text = "italiano";
            schwedischToolStripMenuItem.Text = "svedese";
            schwedischToolStripMenuItem1.Text = "svedese";
            allgemeinToolStripMenuItem.Text = "generale";
            allgemeinToolStripMenuItem1.Text = "generale";
            kategorienToolStripMenuItem.Text = "categorie";
            sprachenToolStripMenuItem.Text = "lingue";
            alleToolStripMenuItem.Text = "tutti";
            freizeitToolStripMenuItem.Text = "tempo libero";
            freizeitUndReisenToolStripMenuItem.Text = "viaggio";
            leichtToolStripMenuItem.Text = "avanzate";
            materialienToolStripMenuItem.Text = "materiali";
            menschUndTierToolStripMenuItem.Text = "umani e animali";
            nativeToolStripMenuItem.Text = "nativo";
            mySQLSetupToolStripMenuItem.Text = "MySQL-impostare";
            naturToolStripMenuItem.Text = "vestito";
            personenbezogeneAdjToolStripMenuItem.Text = "aggettivi personali";
            profiToolStripMenuItem.Text = "professionale";
            programmBeendenToolStripMenuItem.Text = "uscire dal programma";
            schwierigkeitsgradToolStripMenuItem.Text = "livello di difficolta";
            sehrLeichtToolStripMenuItem.Text = "nozioni di base";
            verbenToolStripMenuItem.Text = "altri verbi";
            wetterToolStripMenuItem.Text = "tempo metereologico";
            zahlenToolStripMenuItem.Text = "numeri";
            zeitToolStripMenuItem.Text = "tempo";
            deutschToolStripMenuItem.Text = "dato";
            englischToolStripMenuItem.Text = "cercato";
            menüspracheToolStripMenuItem.Text = "lingua del menu";
            typenToolStripMenuItem.Text = "aree tematiche";
            übersetzungErgänzenToolStripMenuItem.Text = "traduzione completa";
            datenbankHinzufügenToolStripMenuItem.Text = "aggiungi database";
            stadtToolStripMenuItem.Text = "a casa";
            smalltalkToolStripMenuItem.Text = "frasi";
            essenUndTrinkenToolStripMenuItem.Text = "mangiare e bere";
            emotionenToolStripMenuItem.Text = "emozioni";
            sonstigeAdjektiveToolStripMenuItem.Text = "altri aggettivi";
            sonstigeNomenToolStripMenuItem.Text = "altri nomi";

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: " + sehrLeichtToolStripMenuItem.Text;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: " + leichtToolStripMenuItem.Text;
            }
            if (profiToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta " + profiToolStripMenuItem.Text;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: " + nativeToolStripMenuItem.Text;
            }
            if (alleToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: " + alleToolStripMenuItem.Text;
            }
            if (zeitToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + zeitToolStripMenuItem.Text;
            }
            if (allgemeinToolStripMenuItem1.Checked)
            {
                lblCategory.Text = "Categoria: " + allgemeinToolStripMenuItem1.Text;
            }
            if (zahlenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + zahlenToolStripMenuItem.Text;
            }
            if (naturToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + naturToolStripMenuItem.Text;
            }
            if (emotionenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + emotionenToolStripMenuItem.Text;
            }
            if (sonstigeAdjektiveToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + sonstigeAdjektiveToolStripMenuItem.Text;
            }
            if (stadtToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + stadtToolStripMenuItem.Text;
            }
            if (smalltalkToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + smalltalkToolStripMenuItem.Text;
            }
            if (essenUndTrinkenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + essenUndTrinkenToolStripMenuItem.Text;
            }
            if (sonstigeNomenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + sonstigeNomenToolStripMenuItem.Text;
            }
            if (wetterToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + wetterToolStripMenuItem.Text;
            }
            cmdCheckWord.Text = "dai un'occhiata";
            lblOutput.Text = "produzione: ";
            cmdNewWord.Text = "Nuova parola";
        }

        private void espanolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem3.Checked)
            {
                deutschToolStripMenuItem3.Checked = false;
            }
            else
            if (englishToolStripMenuItem.Checked)
            {
                englishToolStripMenuItem.Checked = false;
            }
            else
            if (italianoToolStripMenuItem.Checked)
            {
                italianoToolStripMenuItem.Checked = false;
            }
            else
            if (svenskaToolStripMenuItem.Checked)
            {
                svenskaToolStripMenuItem.Checked = false;
            }
            espanolToolStripMenuItem.Checked = true;

            deutschToolStripMenuItem1.Text = "aleman";
            deutschToolStripMenuItem2.Text = "aleman";
            englischToolStripMenuItem1.Text = "ingles";
            englischToolStripMenuItem2.Text = "ingles";
            spanischToolStripMenuItem.Text = "espanol";
            spanischToolStripMenuItem1.Text = "espanol";
            italienischToolStripMenuItem.Text = "italiano";
            italienischToolStripMenuItem1.Text = "italiano";
            schwedischToolStripMenuItem.Text = "sueco";
            schwedischToolStripMenuItem1.Text = "sueco";
            allgemeinToolStripMenuItem.Text = "generalmente";
            allgemeinToolStripMenuItem1.Text = "generalmente";
            kategorienToolStripMenuItem.Text = "categorias";
            sprachenToolStripMenuItem.Text = "idiomas";
            alleToolStripMenuItem.Text = "todas";
            freizeitToolStripMenuItem.Text = "ocio";
            freizeitUndReisenToolStripMenuItem.Text = "viaje";
            leichtToolStripMenuItem.Text = "avanzado";
            materialienToolStripMenuItem.Text = "materiales";
            menschUndTierToolStripMenuItem.Text = "humanos y animales";
            nativeToolStripMenuItem.Text = "nativo";
            mySQLSetupToolStripMenuItem.Text = "MySQL-configurar";
            naturToolStripMenuItem.Text = "vestir";
            personenbezogeneAdjToolStripMenuItem.Text = "adjetivos peronales";
            profiToolStripMenuItem.Text = "profesional";
            programmBeendenToolStripMenuItem.Text = "salir del programa";
            schwierigkeitsgradToolStripMenuItem.Text = "nivel de dificultad";
            sehrLeichtToolStripMenuItem.Text = "esencial";
            verbenToolStripMenuItem.Text = "otros verbos";
            wetterToolStripMenuItem.Text = "tiempo";
            zahlenToolStripMenuItem.Text = "numberos";
            zeitToolStripMenuItem.Text = "hora";
            deutschToolStripMenuItem.Text = "dado";
            englischToolStripMenuItem.Text = "buscado";
            menüspracheToolStripMenuItem.Text = "idioma del menu";
            typenToolStripMenuItem.Text = "areas tematicas";
            übersetzungErgänzenToolStripMenuItem.Text = "traduccion completa";
            datenbankHinzufügenToolStripMenuItem.Text = "agregar base de datos";
            stadtToolStripMenuItem.Text = "en casa";
            smalltalkToolStripMenuItem.Text = "frases";
            essenUndTrinkenToolStripMenuItem.Text = "para comer y beber";
            emotionenToolStripMenuItem.Text = "emociones";
            sonstigeAdjektiveToolStripMenuItem.Text = "otros adjetivos";
            sonstigeNomenToolStripMenuItem.Text = "other sustantivos";

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "nivel de dificultad: " + sehrLeichtToolStripMenuItem.Text;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "nivel de dificultad: " + leichtToolStripMenuItem.Text;
            }
            if (profiToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "nivel de dificultad: " + profiToolStripMenuItem.Text;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "nivel de dificultad: " + nativeToolStripMenuItem.Text;
            }
            if (alleToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "nivel de dificultad: " + alleToolStripMenuItem.Text;
            }
            if (zeitToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + zeitToolStripMenuItem.Text;
            }
            if (allgemeinToolStripMenuItem1.Checked)
            {
                lblCategory.Text = "Categoria: " + allgemeinToolStripMenuItem1.Text;
            }
            if (zahlenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + zahlenToolStripMenuItem.Text;
            }
            if (naturToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + naturToolStripMenuItem.Text;
            }
            if (emotionenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + emotionenToolStripMenuItem.Text;
            }
            if (sonstigeAdjektiveToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + sonstigeAdjektiveToolStripMenuItem.Text;
            }
            if (stadtToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + stadtToolStripMenuItem.Text;
            }
            if (smalltalkToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + smalltalkToolStripMenuItem.Text;
            }
            if (essenUndTrinkenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + essenUndTrinkenToolStripMenuItem.Text;
            }
            if (sonstigeNomenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + sonstigeNomenToolStripMenuItem.Text;
            }
            if (wetterToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Categoria: " + wetterToolStripMenuItem.Text;
            }
            cmdCheckWord.Text = "cheque";
            lblOutput.Text = "produccion: ";
            cmdNewWord.Text = "Nueva palabra";
        }

        private void svenskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem3.Checked)
            {
                deutschToolStripMenuItem3.Checked = false;
            }
            else
            if (espanolToolStripMenuItem.Checked)
            {
                espanolToolStripMenuItem.Checked = false;
            }
            else
            if (italianoToolStripMenuItem.Checked)
            {
                italianoToolStripMenuItem.Checked = false;
            }
            else
            if (englishToolStripMenuItem.Checked)
            {
                englishToolStripMenuItem.Checked = false;
            }
            svenskaToolStripMenuItem.Checked = true;

            deutschToolStripMenuItem1.Text = "tysk";
            deutschToolStripMenuItem2.Text = "tysk";
            englischToolStripMenuItem1.Text = "engelsk";
            englischToolStripMenuItem2.Text = "engelsk";
            spanischToolStripMenuItem.Text = "spanska";
            spanischToolStripMenuItem1.Text = "spanska";
            italienischToolStripMenuItem.Text = "italienska";
            italienischToolStripMenuItem1.Text = "italienska";
            schwedischToolStripMenuItem.Text = "svenska";
            schwedischToolStripMenuItem1.Text = "svenska";
            allgemeinToolStripMenuItem.Text = "allmänt";
            allgemeinToolStripMenuItem1.Text = "allmänt";
            kategorienToolStripMenuItem.Text = "Kategorier";
            sprachenToolStripMenuItem.Text = "sprak";
            alleToolStripMenuItem.Text = "allt";
            freizeitToolStripMenuItem.Text = "fritid";
            freizeitUndReisenToolStripMenuItem.Text = "resa";
            leichtToolStripMenuItem.Text = "avancerad";
            materialienToolStripMenuItem.Text = "material";
            menschUndTierToolStripMenuItem.Text = "människor och djur";
            nativeToolStripMenuItem.Text = "Inföding";
            mySQLSetupToolStripMenuItem.Text = "MySQL-uppstart";
            naturToolStripMenuItem.Text = "klänning";
            personenbezogeneAdjToolStripMenuItem.Text = "personliga adjektiv";
            profiToolStripMenuItem.Text = "professionell";
            programmBeendenToolStripMenuItem.Text = "avsluta programmet";
            schwierigkeitsgradToolStripMenuItem.Text = "svarighetsgrad";
            sehrLeichtToolStripMenuItem.Text = "Grunderna";
            verbenToolStripMenuItem.Text = "andra verb";
            wetterToolStripMenuItem.Text = "väder";
            zahlenToolStripMenuItem.Text = "tal";
            zeitToolStripMenuItem.Text = "tid";
            deutschToolStripMenuItem.Text = "given";
            englischToolStripMenuItem.Text = "sökt";
            menüspracheToolStripMenuItem.Text = "menysprak";
            typenToolStripMenuItem.Text = "Ämnesomraden";
            übersetzungErgänzenToolStripMenuItem.Text = "komplett översättning";
            datenbankHinzufügenToolStripMenuItem.Text = "lägg till databas";
            stadtToolStripMenuItem.Text = "hemma";
            smalltalkToolStripMenuItem.Text = "Fraser";
            essenUndTrinkenToolStripMenuItem.Text = "att äta och dricka";
            emotionenToolStripMenuItem.Text = "Känslor";
            sonstigeAdjektiveToolStripMenuItem.Text = "andra adjektiv";
            sonstigeNomenToolStripMenuItem.Text = "andra substantiv";

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svärighetsgrad: " + sehrLeichtToolStripMenuItem.Text;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svärighetsgrad: " + leichtToolStripMenuItem.Text;
            }
            if (profiToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svärighetsgrad: " + profiToolStripMenuItem.Text;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svärighetsgrad: " + nativeToolStripMenuItem.Text;
            }
            if (alleToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svärighetsgrad: " + alleToolStripMenuItem.Text;
            }
            if (zeitToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + zeitToolStripMenuItem.Text;
            }
            if (allgemeinToolStripMenuItem1.Checked)
            {
                lblCategory.Text = "Kategorier: " + allgemeinToolStripMenuItem1.Text;
            }
            if (zahlenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + zahlenToolStripMenuItem.Text;
            }
            if (naturToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + naturToolStripMenuItem.Text;
            }
            if (emotionenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + emotionenToolStripMenuItem.Text;
            }
            if (sonstigeAdjektiveToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + sonstigeAdjektiveToolStripMenuItem.Text;
            }
            if (stadtToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + stadtToolStripMenuItem.Text;
            }
            if (smalltalkToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + smalltalkToolStripMenuItem.Text;
            }
            if (essenUndTrinkenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + essenUndTrinkenToolStripMenuItem.Text;
            }
            if (sonstigeNomenToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + sonstigeNomenToolStripMenuItem.Text;
            }
            if (wetterToolStripMenuItem.Checked)
            {
                lblCategory.Text = "Kategorier: " + wetterToolStripMenuItem.Text;
            }
            cmdCheckWord.Text = "kolla upp";
            lblOutput.Text = "produktion: ";
            cmdNewWord.Text = "Nytt ord";
        }

        private void deutschToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem1.Checked)
            {
                englischToolStripMenuItem1.Checked = false;
            }
            else
            if (spanischToolStripMenuItem.Checked)
            {
                spanischToolStripMenuItem.Checked = false;
            }
            else
            if (italienischToolStripMenuItem.Checked)
            {
                italienischToolStripMenuItem.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem.Checked)
            {
                schwedischToolStripMenuItem.Checked = false;
            }
            deutschToolStripMenuItem1.Checked = true;
            MainTexts();
        }

        private void englischToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem1.Checked)
            {
                deutschToolStripMenuItem1.Checked = false;
            }
            else
            if (spanischToolStripMenuItem.Checked)
            {
                spanischToolStripMenuItem.Checked = false;
            }
            else
            if (italienischToolStripMenuItem.Checked)
            {
                italienischToolStripMenuItem.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem.Checked)
            {
                schwedischToolStripMenuItem.Checked = false;
            }
            englischToolStripMenuItem1.Checked = true;
            MainTexts();
        }

        private void italienischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem1.Checked)
            {
                englischToolStripMenuItem1.Checked = false;
            }
            else
            if (spanischToolStripMenuItem.Checked)
            {
                spanischToolStripMenuItem.Checked = false;
            }
            else
            if (deutschToolStripMenuItem1.Checked)
            {
                deutschToolStripMenuItem1.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem.Checked)
            {
                schwedischToolStripMenuItem.Checked = false;
            }
            italienischToolStripMenuItem.Checked = true;
            MainTexts();
        }

        private void spanischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem1.Checked)
            {
                englischToolStripMenuItem1.Checked = false;
            }
            else
            if (deutschToolStripMenuItem1.Checked)
            {
                deutschToolStripMenuItem1.Checked = false;
            }
            else
            if (italienischToolStripMenuItem.Checked)
            {
                italienischToolStripMenuItem.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem.Checked)
            {
                schwedischToolStripMenuItem.Checked = false;
            }
            spanischToolStripMenuItem.Checked = true;
            MainTexts();
        }

        private void schwedischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem1.Checked)
            {
                englischToolStripMenuItem1.Checked = false;
            }
            else
            if (spanischToolStripMenuItem.Checked)
            {
                spanischToolStripMenuItem.Checked = false;
            }
            else
            if (italienischToolStripMenuItem.Checked)
            {
                italienischToolStripMenuItem.Checked = false;
            }
            else
            if (deutschToolStripMenuItem1.Checked)
            {
                deutschToolStripMenuItem1.Checked = false;
            }
            schwedischToolStripMenuItem.Checked = true;
            MainTexts();
        }

        private void deutschToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem2.Checked)
            {
                englischToolStripMenuItem2.Checked = false;
            }
            else
            if (spanischToolStripMenuItem1.Checked)
            {
                spanischToolStripMenuItem1.Checked = false;
            }
            else
            if (italienischToolStripMenuItem1.Checked)
            {
                italienischToolStripMenuItem1.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem1.Checked)
            {
                schwedischToolStripMenuItem1.Checked = false;
            }
            deutschToolStripMenuItem2.Checked = true;
            MainTexts();
        }

        private void englischToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem2.Checked)
            {
                deutschToolStripMenuItem2.Checked = false;
            }
            else
            if (spanischToolStripMenuItem1.Checked)
            {
                spanischToolStripMenuItem1.Checked = false;
            }
            else
            if (italienischToolStripMenuItem1.Checked)
            {
                italienischToolStripMenuItem1.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem1.Checked)
            {
                schwedischToolStripMenuItem1.Checked = false;
            }
            englischToolStripMenuItem2.Checked = true;
            MainTexts();
        }

        private void italienischToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem2.Checked)
            {
                englischToolStripMenuItem2.Checked = false;
            }
            else
            if (spanischToolStripMenuItem1.Checked)
            {
                spanischToolStripMenuItem1.Checked = false;
            }
            else
            if (deutschToolStripMenuItem2.Checked)
            {
                deutschToolStripMenuItem2.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem1.Checked)
            {
                schwedischToolStripMenuItem1.Checked = false;
            }
            italienischToolStripMenuItem1.Checked = true;
            MainTexts();
        }

        private void spanischToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem2.Checked)
            {
                englischToolStripMenuItem2.Checked = false;
            }
            else
            if (deutschToolStripMenuItem2.Checked)
            {
                deutschToolStripMenuItem2.Checked = false;
            }
            else
            if (italienischToolStripMenuItem1.Checked)
            {
                italienischToolStripMenuItem1.Checked = false;
            }
            else
            if (schwedischToolStripMenuItem1.Checked)
            {
                schwedischToolStripMenuItem1.Checked = false;
            }
            spanischToolStripMenuItem1.Checked = true;
            MainTexts();
        }

        private void schwedischToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (englischToolStripMenuItem2.Checked)
            {
                englischToolStripMenuItem2.Checked = false;
            }
            else
            if (spanischToolStripMenuItem1.Checked)
            {
                spanischToolStripMenuItem1.Checked = false;
            }
            else
            if (italienischToolStripMenuItem1.Checked)
            {
                italienischToolStripMenuItem1.Checked = false;
            }
            else
            if (deutschToolStripMenuItem2.Checked)
            {
                deutschToolStripMenuItem2.Checked = false;
            }
            schwedischToolStripMenuItem1.Checked = true;
            MainTexts();
        }

        private void alleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alleToolStripMenuItem.Checked = true;

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                sehrLeichtToolStripMenuItem.Checked = false;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                leichtToolStripMenuItem.Checked = false;
            }
            if (profiToolStripMenuItem.Checked)
            {
                profiToolStripMenuItem.Checked = false;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                nativeToolStripMenuItem.Checked = false;
            }
            if (deutschToolStripMenuItem3.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: Alle";
            }
            if (englishToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: all";
            }
            if (italianoToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: tutti";
            }
            if (espanolToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Nivel de dificultad: todos";
            }
            if (svenskaToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svårighetsnivå: allt";
            }
        }

        private void sehrLeichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sehrLeichtToolStripMenuItem.Checked = true;

            if (alleToolStripMenuItem.Checked)
            {
                alleToolStripMenuItem.Checked = false;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                leichtToolStripMenuItem.Checked = false;
            }
            if (profiToolStripMenuItem.Checked)
            {
                profiToolStripMenuItem.Checked = false;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                nativeToolStripMenuItem.Checked = false;
            }
            if (deutschToolStripMenuItem3.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: Basics";
            }
            if (englishToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: basics";
            }
            if (italianoToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: base";
            }
            if (espanolToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Nivel de dificultad: basico";
            }
            if (svenskaToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svårighetsnivå: grunderna";
            }
        }

        private void leichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leichtToolStripMenuItem.Checked = true;

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                sehrLeichtToolStripMenuItem.Checked = false;
            }
            if (alleToolStripMenuItem.Checked)
            {
                alleToolStripMenuItem.Checked = false;
            }
            if (profiToolStripMenuItem.Checked)
            {
                profiToolStripMenuItem.Checked = false;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                nativeToolStripMenuItem.Checked = false;
            }
            if (deutschToolStripMenuItem3.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: Fortgeschritten";
            }
            if (englishToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: advanced";
            }
            if (italianoToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: avanzato";
            }
            if (espanolToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Nivel de dificultad: avanzado";
            }
            if (svenskaToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svårighetsnivå: avancerad";
            }
        }

        private void profiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profiToolStripMenuItem.Checked = true;

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                sehrLeichtToolStripMenuItem.Checked = false;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                leichtToolStripMenuItem.Checked = false;
            }
            if (alleToolStripMenuItem.Checked)
            {
                alleToolStripMenuItem.Checked = false;
            }
            if (nativeToolStripMenuItem.Checked)
            {
                nativeToolStripMenuItem.Checked = false;
            }
            if (deutschToolStripMenuItem3.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: Profi";
            }
            if (englishToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: expert";
            }
            if (italianoToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: professionale";
            }
            if (espanolToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Nivel de dificultad: profesional";
            }
            if (svenskaToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svårighetsnivå: professionell";
            }
        }

        private void nativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nativeToolStripMenuItem.Checked = true;

            if (sehrLeichtToolStripMenuItem.Checked)
            {
                sehrLeichtToolStripMenuItem.Checked = false;
            }
            if (leichtToolStripMenuItem.Checked)
            {
                leichtToolStripMenuItem.Checked = false;
            }
            if (profiToolStripMenuItem.Checked)
            {
                profiToolStripMenuItem.Checked = false;
            }
            if (alleToolStripMenuItem.Checked)
            {
                alleToolStripMenuItem.Checked = false;
            }
            if (deutschToolStripMenuItem3.Checked)
            {
                lblDifficulty.Text = "Schwierigkeitsgrad: Native";
            }
            if (englishToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Difficulty: native";
            }
            if (italianoToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "livello di difficolta: nativo";
            }
            if (espanolToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Nivel de dificultad: nativo";
            }
            if (svenskaToolStripMenuItem.Checked)
            {
                lblDifficulty.Text = "Svårighetsnivå: infödd";
            }
        }

        private void cmdCheckWord_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbTargetWord.Text == lblOriginWord.Text)
                {
                    if (deutschToolStripMenuItem3.Checked)
                    {
                        lblOutput.Text = "Ausgabe: Super, das war korrekt!";
                    }
                    if (englishToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "ouptut: Awesome, that was correct!";
                    }
                    if (italianoToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Risultato: Fantastico, era corretto!";
                    }
                    if (espanolToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Resultado: ¡Genial, eso fue correcto!";
                    }
                    if (svenskaToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Output: Bra, det var korrekt!";
                    }
                }
                else
                {
                    if (deutschToolStripMenuItem3.Checked)
                    {
                        lblOutput.Text = "Ausgabe: Das war leider falsch!";
                    }
                    if (englishToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Ouptut: Your input was not correct!";
                    }
                    if (italianoToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Output: Purtroppo era sbagliato!";
                    }
                    if (espanolToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Resultado: ¡Desafortunadamente eso estuvo mal!";
                    }
                    if (svenskaToolStripMenuItem.Checked)
                    {
                        lblOutput.Text = "Output: Tyvärr var det fel!";
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmdNewWord_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem1.Checked)
            {
                GlobalVariables.sqlCommand = "SELECT * FROM deutsch WHERE";
            }
            if (englischToolStripMenuItem1.Checked)
            {
                GlobalVariables.sqlCommand = "SELECT * FROM english WHERE";
            }
            if (spanischToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand = "SELECT * FROM espanol WHERE";
            }
            if (italienischToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand = "SELECT * FROM italiano WHERE";
            }
            if (schwedischToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand = "SELECT * FROM svenska WHERE";
            }
            if (alleToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " ";
            }
            if (sehrLeichtToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " difficulty 0 AND word NOT NULL";
            }
            if (leichtToolStripMenuItem.Checked)
            {

                GlobalVariables.sqlCommand += " difficulty 1 AND word NOT NULL";
            }
            if (profiToolStripMenuItem.Checked)
            {

                GlobalVariables.sqlCommand += " difficulty 2 AND word NOT NULL";
            }
            if (nativeToolStripMenuItem.Checked)
            {

                GlobalVariables.sqlCommand += " difficulty 3 AND word NOT NULL";
            }
            if (allgemeinToolStripMenuItem1.Checked)
            {
                GlobalVariables.sqlCommand += ";";
            }
            if (zeitToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand = " AND category \"time\";";
            }
            if (zahlenToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"numbers\";";
            }
            if (emotionenToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"emotions\";";
            }
            if (naturToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"clothes\";";
            }
            if (menschUndTierToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"humans and animals\";";
            }
            if (sonstigeAdjektiveToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"other adjectives\";";
            }
            if (sonstigeNomenToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"other nouns\";";
            }
            if (stadtToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"at home\";";
            }
            if (wetterToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"weather\";";
            }
            if (smalltalkToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"phrases\";";
            }
            if (personenbezogeneAdjToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"personal adjectives\";";
            }
            if (freizeitToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"free time\";";
            }
            if (freizeitUndReisenToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"travel\";";
            }
            if (essenUndTrinkenToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"eat and drink\";";
            }
            if (verbenToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"other verbs\";";
            }
            if (materialienToolStripMenuItem.Checked)
            {
                GlobalVariables.sqlCommand += " AND category \"materials\";";
            }
            //Create interpretable list of database items here
            int size_of_items = 1000;
            int index = rand.Next(size_of_items);
            lblOriginWord.Text = Convert.ToString(index);
            GlobalVariables.sqlCommand = "";
        }
    }
}
