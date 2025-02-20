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
            Console.WriteLine((int)race + ": " + GetDisplayName(race));
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
                Console.WriteLine("Select a Crystalline Type:");
                
                foreach (var crystallineType in Enum.GetValues(typeof(CrystallineType)))
                {
                    Console.WriteLine((int)crystallineType + ": " + crystallineType);
                }
                int crystallineTypeInput = Convert.ToInt32(Console.ReadLine());
                var crystallineTypeSelection = (CrystallineType)crystallineTypeInput;
                
                character = new Crystalline(crystallineTypeSelection);
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
            case RaceEnum.Vikran:
                character = new Vikran();
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

        bool backgroundSkillCheckFailed = true;

        while(backgroundSkillCheckFailed) {
            Console.WriteLine("Select 4 Background Skills (press enter after each):");
            foreach (var voc in Enum.GetValues(typeof(ProficienciesEnum)))
            {
                if (!character.RaceSkills.Contains((ProficienciesEnum)voc)) 
                {
                    Console.WriteLine((int)voc + ": " + voc);
                }
            }

            backgroundSkill1 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill2 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill3 = Convert.ToInt32(Console.ReadLine());
            backgroundSkill4 = Convert.ToInt32(Console.ReadLine());

            HashSet<int> backs = new(){backgroundSkill1, backgroundSkill2, backgroundSkill3, backgroundSkill4};
            backgroundSkillCheckFailed = backs.Count != 4;

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
        };

        #endregion
        Console.WriteLine("\n-------------------------------\n");

        #region Weapon
        // Console.WriteLine("Select 1 Fighting Skill:");
        // foreach (var f in Enum.GetValues(typeof(FightingSkillsEnum)))
        // {
        //     Console.WriteLine((int)f + ": " + f);
        // }
        // character.FightingSkill = (FightingSkillsEnum)Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select 1 Weapon:");
        foreach (WeaponsEnum w in Enum.GetValues(typeof(WeaponsEnum)))
        {
            Console.WriteLine((int)w + ": " + GetDisplayName(w));
        }
        character.Weapon = (WeaponsEnum)Convert.ToInt32(Console.ReadLine());
        #endregion
        Console.WriteLine("\n-------------------------------\n");

        #region Equipment
        int eq1 = 0;
        int eq2 = 0;
        int eq3 = 0;
        int eq4 = 0;
        int eq5 = 0;
        int eq6 = 0;
        int eq7 = 0;
        int eq8 = 0;
        int eq9 = 0;
        int eq10 = 0;

        bool eqCheckFailed = true;
        while(eqCheckFailed) {
            Console.WriteLine("Select 10 pieces of Equipment (press enter after each):");
            foreach (EquipmentEnum eq in Enum.GetValues(typeof(EquipmentEnum)))
            {
                Console.WriteLine((int)eq + ": " + GetDisplayName(eq));
            }

            eq1 = Convert.ToInt32(Console.ReadLine());
            eq2 = Convert.ToInt32(Console.ReadLine());
            eq3 = Convert.ToInt32(Console.ReadLine());
            eq4 = Convert.ToInt32(Console.ReadLine());
            eq5 = Convert.ToInt32(Console.ReadLine());
            eq6 = Convert.ToInt32(Console.ReadLine());
            eq7 = Convert.ToInt32(Console.ReadLine());
            eq8 = Convert.ToInt32(Console.ReadLine());
            eq9 = Convert.ToInt32(Console.ReadLine());
            eq10 = Convert.ToInt32(Console.ReadLine());

            HashSet<int> eqs = new(){eq1, eq2, eq3, eq4, eq5, eq6, eq7, eq8, eq9, eq10};
            eqCheckFailed = eqs.Count != 10;

            if (eqCheckFailed) {
                Console.WriteLine("\nYou can only pick each piece of Equipment one time.");
            }
        }

        character.Equipment = new()
        {
            (EquipmentEnum)eq1,
            (EquipmentEnum)eq2,
            (EquipmentEnum)eq3,
            (EquipmentEnum)eq4,
            (EquipmentEnum)eq5,
            (EquipmentEnum)eq6,
            (EquipmentEnum)eq7,
            (EquipmentEnum)eq8,
            (EquipmentEnum)eq9,
            (EquipmentEnum)eq10,
        };

        #endregion
                        
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

        GeneratePDF(character);
        Console.WriteLine("Done.");
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

    static void GeneratePDF(BaseCharacter character)
    {
        var strippedName = new string(character.Name.ToCharArray()
            .Where(c => !Char.IsWhiteSpace(c))
            .ToArray());

        strippedName = Regex.Replace(strippedName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);

        var dateString = DateTime.Now.ToString("M-d-yyyy");

        Directory.CreateDirectory(Environment.CurrentDirectory + "/output");
        var outputFileName = "/output/" + strippedName + "_" + dateString + ".pdf";
        
        File.Copy(Environment.CurrentDirectory + "/resources/TTCharacterSheet2_Form.pdf", Environment.CurrentDirectory + outputFileName, true);
        
        PdfDocument PDFDoc = PdfReader.Open(Environment.CurrentDirectory + outputFileName, PdfDocumentOpenMode.Modify );

        using (PDFDoc)
        {
            if (PDFDoc.AcroForm.Elements.ContainsKey("/NeedAppearances") == false) PDFDoc.AcroForm.Elements.Add("/NeedAppearances", new PdfBoolean(true)); else PDFDoc.AcroForm.Elements["/NeedAppearances"] = new PdfBoolean(true);

            PdfTextField currentField = (PdfTextField)PDFDoc.AcroForm.Fields["character_name"];
            currentField.Value = new PdfString(character.Name);

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["vit_die"];
            currentField.Value = new PdfString(ConvertVitToDiceString(character.HealthDie));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["anima_threshold"];
            currentField.Value = new PdfString(character.AnimaStat.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["wound_threshold"];
            currentField.Value = new PdfString(character.WoundThreshold.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["pdr"];
            currentField.Value = new PdfString(character.PDR.ToString());
            
            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mdr"];
            currentField.Value = new PdfString(character.MDR.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["movement"];
            currentField.Value = new PdfString(character.Movement.ToString() + "FT");

            // Core Stats
            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["strength"];
            currentField.Value = new PdfString(ConvertCoreStatToDiceString(character.Strength));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["agility"];
            currentField.Value = new PdfString(ConvertCoreStatToDiceString(character.Agility));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["vigor"];
            currentField.Value = new PdfString(ConvertCoreStatToDiceString(character.Vigor));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["wit"];
            currentField.Value = new PdfString(ConvertCoreStatToDiceString(character.Wit));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["presence"];
            currentField.Value = new PdfString(ConvertCoreStatToDiceString(character.Presence));

            // Core Stat Modifiers
            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["strength_m"];
            currentField.Value = new PdfString(character.Strength.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["agility_m"];
            currentField.Value = new PdfString(character.Agility.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["vigor_m"];
            currentField.Value = new PdfString(character.Vigor.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["wit_m"];
            currentField.Value = new PdfString(character.Wit.ToString());

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["presence_m"];
            currentField.Value = new PdfString(character.Presence.ToString());

            // Skills
            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["acrobatics"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Acrobatics));
            
            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["anima"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Anima));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["barter"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Barter));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["brawl"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Brawl));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["charm"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Charm));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["climbing"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Climbing));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["constitution"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Constitution));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cool"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Cool));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["deduction"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Deduction));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["diplomacy"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Diplomacy));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["dodge"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Dodge));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["intimidation"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Intimidation));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["lore"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Lore));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["might"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Might));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["navigation"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Navigation));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["perception"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Perception));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["performance"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Performance));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["piloting"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Piloting));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["rally"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Rally));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["skulduggery"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Skulduggery));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["stealth"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Stealth));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["streetwise"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Streetwise));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["alchemy"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Alchemy));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["botany"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Botany));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cooking"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Cooking));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["enchanting"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Enchanting));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["fishing"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Fishing));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["hunting"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Hunting));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mechanics"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Mechanics));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["medicine"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Medicine));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mining"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Mining));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["rune_crafting"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.RuneCrafting));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["smithing"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Smithing));

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["taming"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Taming));

            // Proficiencies
            foreach (var bProf in character.RaceProficiencies)
            {
                switch(bProf) {
                    case ProficienciesEnum.Acrobatics:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["acrobatics_p"];
                        break;
                    case ProficienciesEnum.Anima:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["anima_p"];
                        break;
                    case ProficienciesEnum.Barter:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["barter_p"];
                        break;
                    case ProficienciesEnum.Brawl:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["brawl_p"];
                        break;
                    case ProficienciesEnum.Charm:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["charm_p"];
                        break;
                    case ProficienciesEnum.Climbing:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["climbing_p"];
                        break;
                    case ProficienciesEnum.Constitution:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["constitution_p"];
                        break;
                    case ProficienciesEnum.Cool:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cool_p"];
                        break;
                    case ProficienciesEnum.Deduction:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["deduction_p"];
                        break;
                    case ProficienciesEnum.Diplomacy:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["diplomacy_p"];
                        break;
                    case ProficienciesEnum.Dodge:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["dodge_p"];
                        break;
                    case ProficienciesEnum.Intimidation:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["intimidation_p"];
                        break;
                    case ProficienciesEnum.Lore:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["lore_p"];
                        break;
                    case ProficienciesEnum.Might:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["might_p"];
                        break;
                    case ProficienciesEnum.Navigation:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["navigation_p"];
                        break;
                    case ProficienciesEnum.Perception:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["perception_p"];
                        break;
                    case ProficienciesEnum.Performance:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["performance_p"];
                        break;
                    case ProficienciesEnum.Piloting:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["piloting_p"];
                        break;
                    case ProficienciesEnum.Rally:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["rally_p"];
                        break;
                    case ProficienciesEnum.Skulduggery:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["skulduggery_p"];
                        break;
                    case ProficienciesEnum.Stealth:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["stealth_p"];
                        break;
                    case ProficienciesEnum.Streetwise:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["streetwise_p"];
                        break;
                    case ProficienciesEnum.Alchemy:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["alchemy_p"];
                        break;
                    case ProficienciesEnum.Botany:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["botany_p"];
                        break;
                    case ProficienciesEnum.Cooking:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["cooking_p"];
                        break;
                    case ProficienciesEnum.Enchanting:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["enchanting_p"];
                        break;
                    case ProficienciesEnum.Fishing:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["fishing_p"];
                        break;
                    case ProficienciesEnum.Hunting:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["hunting_p"];
                        break;
                    case ProficienciesEnum.Mechanics:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mechanics_p"];
                        break;
                    case ProficienciesEnum.Medicine:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["medicine_p"];
                        break;
                    case ProficienciesEnum.Mining:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["mining_p"];
                        break;
                    case ProficienciesEnum.RuneCrafting:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["rune_crafting_p"];
                        break;
                    case ProficienciesEnum.Smithing:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["smithing_p"];
                        break;
                    case ProficienciesEnum.Taming:
                        currentField = (PdfTextField)PDFDoc.AcroForm.Fields["taming_p"];
                        break;
                    default:
                        break;
                }

                currentField.Value = new PdfString("+2");
            }


            // Background Skills

            PdfCheckBoxField currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["acrobatics_b"];
            foreach (var bProf in character.BackgroundProfSkills.Concat(character.RaceSkills))
            {
                switch(bProf) {
                    case ProficienciesEnum.Acrobatics:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["acrobatics_b"];
                        break;
                    case ProficienciesEnum.Anima:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["anima_b"];
                        break;
                    case ProficienciesEnum.Barter:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["barter_b"];
                        break;
                    case ProficienciesEnum.Brawl:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["brawl_b"];
                        break;
                    case ProficienciesEnum.Charm:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["charm_b"];
                        break;
                    case ProficienciesEnum.Climbing:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["climbing_b"];
                        break;
                    case ProficienciesEnum.Constitution:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["constitution_b"];
                        break;
                    case ProficienciesEnum.Cool:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["cool_b"];
                        break;
                    case ProficienciesEnum.Deduction:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["deduction_b"];
                        break;
                    case ProficienciesEnum.Diplomacy:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["diplomacy_b"];
                        break;
                    case ProficienciesEnum.Dodge:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["dodge_b"];
                        break;
                    case ProficienciesEnum.Intimidation:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["intimidation_b"];
                        break;
                    case ProficienciesEnum.Lore:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["lore_b"];
                        break;
                    case ProficienciesEnum.Might:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["might_b"];
                        break;
                    case ProficienciesEnum.Navigation:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["navigation_b"];
                        break;
                    case ProficienciesEnum.Perception:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["perception_b"];
                        break;
                    case ProficienciesEnum.Performance:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["performance_b"];
                        break;
                    case ProficienciesEnum.Piloting:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["piloting_b"];
                        break;
                    case ProficienciesEnum.Rally:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["rally_b"];
                        break;
                    case ProficienciesEnum.Skulduggery:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["skulduggery_b"];
                        break;
                    case ProficienciesEnum.Stealth:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["stealth_b"];
                        break;
                    case ProficienciesEnum.Streetwise:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["streetwise_b"];
                        break;
                    case ProficienciesEnum.Alchemy:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["alchemy_b"];
                        break;
                    case ProficienciesEnum.Botany:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["botany_b"];
                        break;
                    case ProficienciesEnum.Cooking:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["cooking_b"];
                        break;
                    case ProficienciesEnum.Enchanting:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["enchanting_b"];
                        break;
                    case ProficienciesEnum.Fishing:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["fishing_b"];
                        break;
                    case ProficienciesEnum.Hunting:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["hunting_b"];
                        break;
                    case ProficienciesEnum.Mechanics:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["mechanics_b"];
                        break;
                    case ProficienciesEnum.Medicine:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["medicine_b"];
                        break;
                    case ProficienciesEnum.Mining:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["mining_b"];
                        break;
                    case ProficienciesEnum.RuneCrafting:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["rune_crafting_b"];
                        break;
                    case ProficienciesEnum.Smithing:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["smithing_b"];
                        break;
                    case ProficienciesEnum.Taming:
                        currentCheckBoxField = (PdfCheckBoxField)PDFDoc.AcroForm.Fields["taming_b"];
                        break;
                    default:
                        break;
                }

                currentCheckBoxField.Value = new PdfString("Yes_furo");
            }

            // Eqiupment

            string equipmentList = "";
            foreach(EquipmentEnum eq in character.Equipment) {
                equipmentList += GetDisplayName(eq) + "\n";
            }

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["equipment"];
            currentField.Value = new PdfString(equipmentList);

            // Weapon
            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["weapon_1"];
            currentField.Value = new PdfString(GetDisplayName(character.Weapon));
            
            PDFDoc.Save(Environment.CurrentDirectory + outputFileName);
        }
    }

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