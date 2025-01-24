namespace TravelersTaleCharacterCreator;

using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;

class Program
{
    static void Main(string[] args)
    {
        BaseCharacter character = new BaseCharacter();
        
        Console.WriteLine("Welcome to Traveler's Tale Character Creator\n\n");

        #region Race Selection

        Console.WriteLine("Select a Race:");
        foreach (RaceEnum race in Enum.GetValues(typeof(RaceEnum)))
        {
            // Limit race selection for now
            if (race == RaceEnum.Human || race == RaceEnum.Desamir || race == RaceEnum.Dagon) {
                Console.WriteLine((int)race + ": " + GetDisplayName(race));
            }
        }
        int raceInput = Convert.ToInt32(Console.ReadLine());
        var raceSelection = (RaceEnum)raceInput;

        switch(raceSelection) {
            case RaceEnum.Angelicon:
                Console.WriteLine("Select an Angelicon Type:");
                
                foreach (var angeliconType in Enum.GetValues(typeof(AngeliconType)))
                {
                    Console.WriteLine((int)angeliconType + ": " + angeliconType);
                }
                int angeliconTypeInput = Convert.ToInt32(Console.ReadLine());
                var angeliconTypeSelection = (AngeliconType)angeliconTypeInput;

                character = new Angelicon(angeliconTypeSelection);
                break;
            case RaceEnum.Calmara:
                Console.WriteLine("Select a Calmara Type:");
                
                foreach (var calmaraType in Enum.GetValues(typeof(CalmaraType)))
                {
                    Console.WriteLine((int)calmaraType + ": " + calmaraType);
                }
                int calmaraTypeInput = Convert.ToInt32(Console.ReadLine());
                var calmaraTypeSelection = (CalmaraType)calmaraTypeInput;

                character = new Calmara(calmaraTypeSelection);
                break;
            case RaceEnum.Crystalline:
                character = new Crystalline();
                break;
            case RaceEnum.Dagon:
                character = new Dagon();
                break;
            case RaceEnum.Desamir:
                character = new Desamir();
                break;
            case RaceEnum.FallenAngelicon:
                Console.WriteLine("Select a Fallen Angelicon Type:");
                
                foreach (var angeliconType in Enum.GetValues(typeof(AngeliconType)))
                {
                    Console.WriteLine((int)angeliconType + ": " + angeliconType);
                }
                int fallenAngeliconTypeInput = Convert.ToInt32(Console.ReadLine());
                var fallenAngeliconTypeSelection = (FallenAngeliconType)fallenAngeliconTypeInput;

                character = new FallenAngelicon(fallenAngeliconTypeSelection);
                break;
            case RaceEnum.Human:
                character = new Human();
                break;
            case RaceEnum.Jotunn:
                Console.WriteLine("Select a Jotunn Type:");
                
                foreach (var jotunnType in Enum.GetValues(typeof(JotunnType)))
                {
                    Console.WriteLine((int)jotunnType + ": " + jotunnType);
                }
                int jotunnTypeInput = Convert.ToInt32(Console.ReadLine());
                var jotunnTypeSelection = (JotunnType)jotunnTypeInput;

                character = new Jotunn(jotunnTypeSelection);
                break;
            case RaceEnum.Nitromech:
                character = new Nitromech();
                break;
            case RaceEnum.Shadeling:
                character = new Shadeling();
                break;
            case RaceEnum.Sharkfolk:
                Console.WriteLine("Select a Shark Type:");
                
                foreach (var sharkType in Enum.GetValues(typeof(SharkType)))
                {
                    Console.WriteLine((int)sharkType + ": " + sharkType);
                }
                int sharkTypeInput = Convert.ToInt32(Console.ReadLine());
                var sharkTypeSelection = (SharkType)sharkTypeInput;

                character = new Sharkfolk(sharkTypeSelection);
                break;
            case RaceEnum.Vereni:
                character = new Vereni();
                break;
            case RaceEnum.Vikra:
                character = new Vikra();
                break;
            default:
                break;
        }
        #endregion
        Console.WriteLine("\n-------------------------------\n");

        #region Background
        Console.WriteLine("Choose your character's background skills (need half the XP to level them up):");
        int backgroundSkill1 = 0;
        int backgroundSkill2 = 0;
        int backgroundSkill3 = 0;
        int backgroundSkill4 = 0;
        int backgroundSkill5 = 0;
        int backgroundSkill6 = 0;
        int backgroundSkill7 = 0;

        bool backgroundSkillCheckFailed = true;

        while(backgroundSkillCheckFailed) {
            Console.WriteLine("Select 7 Proficiencies (press enter after each):");
            foreach (var voc in Enum.GetValues(typeof(ProficienciesEnum)))
            {
                Console.WriteLine((int)voc + ": " + voc);
            }

            backgroundSkill1 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill2 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill3 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill4 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill5 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill6 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill7 = Convert.ToInt32(Console.ReadLine());

            HashSet<int> backs = new(){backgroundSkill1, backgroundSkill2, backgroundSkill3, backgroundSkill4, backgroundSkill5, backgroundSkill6, backgroundSkill7};
            backgroundSkillCheckFailed = backs.Count != 7;

            if (backgroundSkillCheckFailed) {
                Console.WriteLine("\nYou can only pick each skill one time.");
            }
        }

        character.BackgroundProfSkills = new()
        {
            (ProficienciesEnum)backgroundSkill1,
            (ProficienciesEnum)backgroundSkill2,
            (ProficienciesEnum)backgroundSkill3,
            (ProficienciesEnum)backgroundSkill4,
            (ProficienciesEnum)backgroundSkill5,
            (ProficienciesEnum)backgroundSkill6,
            (ProficienciesEnum)backgroundSkill7,
        };


        Console.WriteLine("Select 1 Fighting Skill:");
        foreach (var f in Enum.GetValues(typeof(FightingSkillsEnum)))
        {
            Console.WriteLine((int)f + ": " + f);
        }
        character.FightingSkill = (FightingSkillsEnum)Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select 1 Weapon:");
        foreach (var w in Enum.GetValues(typeof(WeaponsEnum)))
        {
            Console.WriteLine((int)w + ": " + w);
        }
        character.Weapon = (WeaponsEnum)Convert.ToInt32(Console.ReadLine());

        #endregion
        Console.WriteLine("\n-------------------------------\n");
                        
        #region Wound Threshold
        Console.WriteLine("Calculating Wound Threshold...");
        int healthDie = character.HealthDie;

        character.WoundThreshold = healthDie + character.Vigor;
        Console.WriteLine("Your Wound Threshold is: " + character.WoundThreshold + "\n");
        #endregion
        Console.WriteLine("\n-------------------------------\n");
        #region Anima
        Console.WriteLine("Rolling for Anima...");
        character.AnimaStat = RollForAnima();
        Console.WriteLine("Your Anima is: " + character.AnimaStat + "\n");
        #endregion
        Console.WriteLine("\n-------------------------------\n");
        
        //todo: weapon, not now

        //todo: shield, not now

        // equipment

        #region Armor
        
        var no = new NoArmor();
        var light = new LightArmor();
        var medium = new MediumArmor();
        var heavy = new HeavyArmor();
        
        Console.WriteLine("1: No Armor ~ +" + no.WoundThresholdModifier + " Wound Threshold and +" + no.MovementModifier + " MVMT");
        Console.WriteLine("2: Light Armor ~ +" + light.WoundThresholdModifier + " Wound Threshold and +" + light.MovementModifier + " MVMT");
        Console.WriteLine("3: Medium Armor ~ +" + + medium.WoundThresholdModifier + " Wound Threshold and +" + medium.MovementModifier + " MVMT");
        Console.WriteLine("4: Heavy Armor ~ +" + heavy.WoundThresholdModifier + " Wound Threshold and -" + heavy.MovementModifier + " MVMT");

        int armorInput = Convert.ToInt32(Console.ReadLine());
        switch(armorInput) {
            case 1:
                character.Armor = new NoArmor();
                break;
            case 2:
                character.Armor = new LightArmor();
                break;
            case 3:
                character.Armor = new MediumArmor();
                break;
            case 4:
                character.Armor = new HeavyArmor();
                break;
            default:
                break;
        }
        character.WoundThreshold += character.Armor.WoundThresholdModifier;
        character.Movement += character.Armor.MovementModifier;
        Console.WriteLine("\n-------------------------------\n");

        #endregion

        Console.WriteLine("Input Character Name:");
        character.Name = Console.ReadLine();

        //GeneratePDF(character);
        //Console.WriteLine("Done.");

        PrintCharacter(character);
    }

    static void PrintCharacter(BaseCharacter character)
    {
        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");
        
        Console.WriteLine("Core Stats:");
        Console.WriteLine("Strength: " + ConvertCoreStatToDiceString(character.Strength) + " +" + character.Strength);
        Console.WriteLine("Agility: " + ConvertCoreStatToDiceString(character.Agility) + " +" + character.Agility);
        Console.WriteLine("Vigor: " + ConvertCoreStatToDiceString(character.Vigor) + " +" + character.Vigor);
        Console.WriteLine("Wit: " + ConvertCoreStatToDiceString(character.Wit) + " +" + character.Wit);
        Console.WriteLine("Presence: " + ConvertCoreStatToDiceString(character.Presence) + " +" + character.Presence);

        Console.WriteLine("\n--------------------------------------------\n");

        Console.WriteLine("Character Attributes:");
        Console.WriteLine("Wound Threshold: " + character.WoundThreshold);
        Console.WriteLine("Anima: " + character.AnimaStat);
        Console.WriteLine("Vit Die: " + ConvertVitToDiceString(character.HealthDie));
        Console.WriteLine("PDR: " + character.PDR);
        Console.WriteLine("MDR: " + character.MDR);
        Console.WriteLine("MVMT: " + character.Movement);

        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine("Proficiencies:");
        Console.WriteLine("Climbing: " + ConvertIntToDiceString(character.Climbing) + CheckProf(character, ProficienciesEnum.Climbing));
        Console.WriteLine("Lifting: " + ConvertIntToDiceString(character.Lifting) + CheckProf(character, ProficienciesEnum.Lifting));
        Console.WriteLine("Smithing: " + ConvertIntToDiceString(character.Smithing) + CheckProf(character, ProficienciesEnum.Smithing));
        Console.WriteLine("Mining: " + ConvertIntToDiceString(character.Mining) + CheckProf(character, ProficienciesEnum.Mining));

        Console.WriteLine("\nSkulduggery: " + ConvertIntToDiceString(character.Skulduggery) + CheckProf(character, ProficienciesEnum.Skulduggery));
        Console.WriteLine("Stealth: " + ConvertIntToDiceString(character.Stealth) + CheckProf(character, ProficienciesEnum.Stealth));
        Console.WriteLine("Leaping: " + ConvertIntToDiceString(character.Leaping) + CheckProf(character, ProficienciesEnum.Leaping));
        Console.WriteLine("Lockpicking: " + ConvertIntToDiceString(character.Lockpicking) + CheckProf(character, ProficienciesEnum.Lockpicking));
        Console.WriteLine("Mechanics: " + ConvertIntToDiceString(character.Mechanics) + CheckProf(character, ProficienciesEnum.Mechanics));

        Console.WriteLine("\nConstitution: " + ConvertIntToDiceString(character.Constitution) + CheckProf(character, ProficienciesEnum.Constitution));
        Console.WriteLine("Hunting: " + ConvertIntToDiceString(character.Hunting) + CheckProf(character, ProficienciesEnum.Hunting));
        Console.WriteLine("Intimidation: " + ConvertIntToDiceString(character.Intimidation) + CheckProf(character, ProficienciesEnum.Intimidation));
        Console.WriteLine("Botany: " + ConvertIntToDiceString(character.Botany) + CheckProf(character, ProficienciesEnum.Botany));
        Console.WriteLine("Fishing: " + ConvertIntToDiceString(character.Fishing) + CheckProf(character, ProficienciesEnum.Fishing));
        Console.WriteLine("Cooking: " + ConvertIntToDiceString(character.Cooking) + CheckProf(character, ProficienciesEnum.Cooking));
        Console.WriteLine("Taming: " + ConvertIntToDiceString(character.Taming) + CheckProf(character, ProficienciesEnum.Taming));

        Console.WriteLine("\nNavigation: " + ConvertIntToDiceString(character.Navigation) + CheckProf(character, ProficienciesEnum.Navigation));
        Console.WriteLine("Streetwise: " + ConvertIntToDiceString(character.Streetwise) + CheckProf(character, ProficienciesEnum.Streetwise));
        Console.WriteLine("Lore: " + ConvertIntToDiceString(character.Lore) + CheckProf(character, ProficienciesEnum.Lore));
        Console.WriteLine("Perception: " + ConvertIntToDiceString(character.Perception) + CheckProf(character, ProficienciesEnum.Perception));
        Console.WriteLine("Anima: " + ConvertIntToDiceString(character.Anima) + CheckProf(character, ProficienciesEnum.Anima));
        Console.WriteLine("Deduction: " + ConvertIntToDiceString(character.Deduction) + CheckProf(character, ProficienciesEnum.Deduction));
        Console.WriteLine("Medicine: " + ConvertIntToDiceString(character.Medicine) + CheckProf(character, ProficienciesEnum.Medicine));
        Console.WriteLine("Alchemy: " + ConvertIntToDiceString(character.Alchemy) + CheckProf(character, ProficienciesEnum.Alchemy));

        Console.WriteLine("\nBarter: " + ConvertIntToDiceString(character.Barter) + CheckProf(character, ProficienciesEnum.Barter));
        Console.WriteLine("Charm: " + ConvertIntToDiceString(character.Charm) + CheckProf(character, ProficienciesEnum.Charm));
        Console.WriteLine("Rally: " + ConvertIntToDiceString(character.Rally) + CheckProf(character, ProficienciesEnum.Rally));
        Console.WriteLine("Cool: " + ConvertIntToDiceString(character.Cool) + CheckProf(character, ProficienciesEnum.Cool));
        Console.WriteLine("Diplomacy: " + ConvertIntToDiceString(character.Diplomacy) + CheckProf(character, ProficienciesEnum.Diplomacy));
        Console.WriteLine("Performance: " + ConvertIntToDiceString(character.Performance) + CheckProf(character, ProficienciesEnum.Performance));
        Console.WriteLine("Enchanting: " + ConvertIntToDiceString(character.Enchanting) + CheckProf(character, ProficienciesEnum.Enchanting));
        Console.WriteLine("Rune Crafting: " + ConvertIntToDiceString(character.RuneCrafting) + CheckProf(character, ProficienciesEnum.RuneCrafting));

        Console.WriteLine("\n--------------------------------------------\n");
        Console.WriteLine("Fighting Skills:");
        Console.WriteLine("Grapple: " + ConvertIntToDiceString(character.Grapple) + CheckFightingSkill(character, FightingSkillsEnum.Grapple));
        Console.WriteLine("Shove: " + ConvertIntToDiceString(character.Shove) + CheckFightingSkill(character, FightingSkillsEnum.Shove));
        Console.WriteLine("Block: " + ConvertIntToDiceString(character.Block) + CheckFightingSkill(character, FightingSkillsEnum.Block));
        Console.WriteLine("Dodge: " + ConvertIntToDiceString(character.Dodge) + CheckFightingSkill(character, FightingSkillsEnum.Dodge));
        Console.WriteLine("Resolve: " + ConvertIntToDiceString(character.Resolve) + CheckFightingSkill(character, FightingSkillsEnum.Resolve));
        Console.WriteLine("Parry: " + ConvertIntToDiceString(character.Parry) + CheckFightingSkill(character, FightingSkillsEnum.Parry));
        Console.WriteLine("Disarm: " + ConvertIntToDiceString(character.Disarm) + CheckFightingSkill(character, FightingSkillsEnum.Disarm));
    }

    static string CheckProf(BaseCharacter character, ProficienciesEnum p)
    {
        string retString = "";
        
        if (character.RaceProficiencies.Contains(p))
        {
            retString += " + 2";
        }

        if (character.BackgroundProfSkills.Contains(p))
        {
            retString += "      ☑";
        }

        return retString;
    }

    static string CheckFightingSkill(BaseCharacter character, FightingSkillsEnum f)
    {
        return character.FightingSkill == f ? "      ☑" : "";
    }

    // static void GeneratePDF(BaseCharacter character)
    // {
    //     var strippedName = new string(character.Name.ToCharArray()
    //         .Where(c => !Char.IsWhiteSpace(c))
    //         .ToArray());

    //     strippedName = Regex.Replace(strippedName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);

    //     var dateString = DateTime.Now.ToString("M-d-yyyy");

    //     Directory.CreateDirectory(Environment.CurrentDirectory + "/output");
    //     var outputFileName = "/output/" + strippedName + "_" + dateString + ".pdf";
        
    //     File.Copy(Environment.CurrentDirectory + "/resources/TTCharacterSheet2_Form.pdf", Environment.CurrentDirectory + outputFileName, true);
        
    //     PdfDocument PDFDoc = PdfReader.Open(Environment.CurrentDirectory + outputFileName, PdfDocumentOpenMode.Modify );

    //     using (PDFDoc)
    //     {
    //         if (PDFDoc.AcroForm.Elements.ContainsKey("/NeedAppearances") == false) PDFDoc.AcroForm.Elements.Add("/NeedAppearances", new PdfBoolean(true)); else PDFDoc.AcroForm.Elements["/NeedAppearances"] = new PdfBoolean(true);

    //         PdfTextField currentField = (PdfTextField)PDFDoc.AcroForm.Fields["character_name"];
    //         currentField.Value = new PdfString(character.Name);

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["race"];
    //         currentField.Value = new PdfString(character.Race);

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["vit_die"];
    //         currentField.Value = new PdfString(ConvertVitToDiceString(character.HealthDie, character.Persona));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["anima"];
    //         currentField.Value = new PdfString(character.AnimaStat.ToString());

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["vitality"];
    //         currentField.Value = new PdfString(character.WoundThreshold.ToString());

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["defense_rating"];
    //         if (character.Armor != null) {
    //             currentField.Value = new PdfString(character.Armor.DefenseRating.ToString());
    //         } else {
    //             currentField.Value = new PdfString(0.ToString());
    //         }

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["movement"];
    //         currentField.Value = new PdfString(character.Movement.ToString() + "FT");

    //         // Core Stats
    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["power"];
    //         currentField.Value = new PdfString(character.Strength.ToString());

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["speed"];
    //         currentField.Value = new PdfString(character.Agility.ToString());

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["vigor"];
    //         currentField.Value = new PdfString(character.Vigor.ToString());

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["wit"];
    //         currentField.Value = new PdfString(character.Wit.ToString());

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["presence"];
    //         currentField.Value = new PdfString(character.Presence.ToString());

    //         // Proficiencies
    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["athletics"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Athletics));
            
    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["strength"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Strength));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["intimidation"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Intimidation));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["skulduggery"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Skulduggery));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["stealth"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Stealth));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["acrobatics"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Acrobatics));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["constitution"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Constitution));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["navigation"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Navigation));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["survival"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Survival));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["lore"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Lore));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["perception"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Perception));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["anima_prof"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Anima));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["deduction"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Deduction));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["streetwise"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Streetwise));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["barter"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Barter));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["charm"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Charm));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["rally"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Rally));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cool"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Cool));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["diplomacy"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Diplomacy));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["block"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Block));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["dodge"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Dodge));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["grapple"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Grapple));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["disarm"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Disarm));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["shove"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Shove));

    //         // Vocational Skills
    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["farming"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Farming));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["science"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Science));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cooking"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Cooking));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["medicine"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Medicine));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mechanics"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Mechanics));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["carpentry"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Carpentry));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["smithing"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Smithing));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["masonry"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Masonry));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cartography"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Cartography));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["scavenging"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Scavenging));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mounting"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Mounting));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["fishing"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Fishing));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["alchemy"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Alchemy));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["weaving"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Weaving));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["leatherworking"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Leatherworking));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["music"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Music));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["art"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Art));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["botany"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Botany));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["hunting"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Hunting));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["skinning"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Skinning));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["foraging"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Foraging));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["taming"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Taming));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["piloting"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Piloting));

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["sailing"];
    //         currentField.Value = new PdfString(ConvertIntToDiceString(character.Sailing));

    //         // Background Skills

    //         PdfCheckBoxField currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["athletics_b"];
    //         foreach (var bProf in character.BackgroundProfSkills)
    //         {
    //             switch(bProf) {
    //                 case ProficienciesEnum.Athletics:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["athletics_b"];
    //                     break;
    //                 case ProficienciesEnum.Strength:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["strength_b"];
    //                     break;
    //                 case ProficienciesEnum.Intimidation:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["intimidation_b"];
    //                     break;
    //                 case ProficienciesEnum.Skulduggery:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["skulduggery_b"];
    //                     break;
    //                 case ProficienciesEnum.Stealth:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["stealth_b"];
    //                     break;
    //                 case ProficienciesEnum.Acrobatics:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["acrobatics_b"];
    //                     break;
    //                 case ProficienciesEnum.Constitution:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["constitution_b"];
    //                     break;
    //                 case ProficienciesEnum.Navigation:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["navigation_b"];
    //                     break;
    //                 case ProficienciesEnum.Survival:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["survival_b"];
    //                     break;
    //                 case ProficienciesEnum.Lore:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["lore_b"];
    //                     break;
    //                 case ProficienciesEnum.Perception:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["perception_b"];
    //                     break;
    //                 case ProficienciesEnum.Anima:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["anima_b"];
    //                     break;
    //                 case ProficienciesEnum.Deduction:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["deduction_b"];
    //                     break;
    //                 case ProficienciesEnum.Streetwise:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["streetwise_b"];
    //                     break;
    //                 case ProficienciesEnum.Barter:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["barter_b"];
    //                     break;
    //                 case ProficienciesEnum.Charm:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["charm_b"];
    //                     break;
    //                 case ProficienciesEnum.Rally:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["rally_b"];
    //                     break;
    //                 case ProficienciesEnum.Cool:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["cool_b"];
    //                     break;
    //                 case ProficienciesEnum.Diplomacy:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["diplomacy_b"];
    //                     break;
    //                 default:
    //                     break;
    //             }

    //             currentCheckBoxField.Value = new PdfString("Yes_furo");
    //         }

    //         foreach (var bVoc in character.BackgroundVocSkills)
    //         {
    //             switch(bVoc) {
    //                 case VocationalSkillsEnum.Farming:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["farming_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Science:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["science_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Cooking:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["cooking_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Medicine:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["medicine_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Mechanics:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["mechanics_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Masonry:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["masonry_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Cartography:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["cartography_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Scavenging:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["scavenging_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Carpentry:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["carpentry_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Smithing:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["smithing_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Mounting:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["mounting_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Fishing:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["fishing_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Alchemy:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["alchemy_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Weaving:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["weaving_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Leatherworking:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["leatherworking_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Music:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["music_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Art:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["art_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Botany:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["botany_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Hunting:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["hunting_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Skinning:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["skinning_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Foraging:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["foraging_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Taming:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["taming_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Piloting:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["piloting_b"];
    //                     break;
    //                 case VocationalSkillsEnum.Sailing:
    //                     currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["sailing_b"];
    //                     break;
    //                 default:
    //                     break;
    //             }

    //             currentCheckBoxField.Value = new PdfString("Yes_furo");
    //         }

    //         // Eqiupment

    //         string equipmentList = "";
    //         foreach(var eq in character.Equipment) {
    //             if (eq != EquipmentEnum.Other) 
    //             {
    //                 equipmentList += GetDisplayName(eq) + "\n\n";
    //             }
    //             else 
    //             {
    //                 equipmentList += character.otherEquipment + "\n\n";
    //             }
    //         }

    //         currentField = (PdfTextField)PDFDoc.AcroForm.Fields["equipment"];
    //         currentField.Value = new PdfString(equipmentList);
            
    //         PDFDoc.Save(Environment.CurrentDirectory + outputFileName);
    //     }
    // }

    public static string ConvertIntToDiceString(int val)
    {
        if (val < 0) {
            return val.ToString();
        }
        
        switch(val)
        {
            case 0:
                return "1d4*";
            case 1:
                return "1d4";
            case 2:
                return "2d4";
            case 3:
                return "1d4+1d6";
            case 4:
                return "2d6";
            case 5:
                return "1d6+1d8";
            case 6:
                return "2d8";
            case 7:
                return "1d8+1d10";
            case 8:
                return "2d10";
            case 9:
                return "1d10+1d12";
            case 10:
                return "2d12";
            default:
                return "bad dice val";
        }
    }

    public static string ConvertCoreStatToDiceString(int val)
    {
        if (val < 0) {
            return val.ToString();
        }
        
        switch(val)
        {
            case 0:
                return "1d4*";
            case 1:
                return "1d4";
            case 2:
                return "1d6";
            case 3:
                return "1d8";
            case 4:
                return "1d10";
            case 5:
                return "1d12";
            default:
                return "bad dice val";
        }
    }

    public static string ConvertVitToDiceString(int vit)
    {
        return "1d" + vit;
    }

    static int RollForAnima()
    {
        int diceNum = 6;
        
        Random rnd = new Random();
        int sum = 0;

        for(var i = 0; i < 3; i++)
        {
            // generate from 2 to 6
            sum += rnd.Next(2, diceNum + 1);
        }

        return sum;
    }

    static string GetDisplayName(Enum enumValue)
    {
        return enumValue.GetType()
        .GetMember(enumValue.ToString())
        .First()
        .GetCustomAttribute<DisplayAttribute>()
        ?.GetName();
    }
}