﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TradeTrackerProject.TestCases.Non_TK_ShopOpen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BWUMaintenance recording.
    /// </summary>
    [TestModule("c78c8c11-4499-4c4a-962d-46e33843a7f9", ModuleType.Recording, 1)]
    public partial class BWUMaintenance : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TradeTrackerProject.TradeTrackerProjectRepository repository.
        /// </summary>
        public static TradeTrackerProject.TradeTrackerProjectRepository repo = TradeTrackerProject.TradeTrackerProjectRepository.Instance;

        static BWUMaintenance instance = new BWUMaintenance();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BWUMaintenance()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BWUMaintenance Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUMaintenance' at Center", repo.PkComTradetracker.ShopOpen_BWUMaintenanceInfo, new RecordItemIndex(0));
            repo.PkComTradetracker.ShopOpen_BWUMaintenance.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_BWUMaintenance_validation'.", repo.PkComTradetracker.ShopOpen_BWUMaintenance_validationInfo, new RecordItemIndex(1));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_BWUMaintenance_validationInfo, ShopOpen_BWUMaintenance_validation_Screenshot1, ShopOpen_BWUMaintenance_validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUAllocated' at Center", repo.PkComTradetracker.ShopOpen_BWUAllocatedInfo, new RecordItemIndex(2));
            repo.PkComTradetracker.ShopOpen_BWUAllocated.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUStatus' at Center", repo.PkComTradetracker.ShopOpen_BWUStatusInfo, new RecordItemIndex(3));
            repo.PkComTradetracker.ShopOpen_BWUStatus.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(4));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ViewPlanogram' at Center", repo.PkComTradetracker.ShopOpen_ViewPlanogramInfo, new RecordItemIndex(5));
            repo.PkComTradetracker.ShopOpen_ViewPlanogram.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(6));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_EditBWU' at Center", repo.PkComTradetracker.ShopOpen_EditBWUInfo, new RecordItemIndex(7));
            repo.PkComTradetracker.ShopOpen_EditBWU.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.UnitPlanogramScreen.ShopOpen_RightChangeBWU' at Center", repo.PkComTradetracker.UnitPlanogramScreen.ShopOpen_RightChangeBWUInfo, new RecordItemIndex(8));
            repo.PkComTradetracker.UnitPlanogramScreen.ShopOpen_RightChangeBWU.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.UnitPlanogramScreen.ShopOpen_RightChangeBWU' at Center", repo.PkComTradetracker.UnitPlanogramScreen.ShopOpen_RightChangeBWUInfo, new RecordItemIndex(9));
            repo.PkComTradetracker.UnitPlanogramScreen.ShopOpen_RightChangeBWU.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.UnitPlanogramScreen.ShopOpen_LeftChangeBWU' at Center", repo.PkComTradetracker.UnitPlanogramScreen.ShopOpen_LeftChangeBWUInfo, new RecordItemIndex(10));
            repo.PkComTradetracker.UnitPlanogramScreen.ShopOpen_LeftChangeBWU.Touch();
            Delay.Milliseconds(500);
            
            ConstantUserCode.UserCodeCollection.setPlanogram();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(12));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ViewPlanogram' at Center", repo.PkComTradetracker.ShopOpen_ViewPlanogramInfo, new RecordItemIndex(13));
            repo.PkComTradetracker.ShopOpen_ViewPlanogram.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(14));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUStatus' at Center", repo.PkComTradetracker.ShopOpen_BWUStatusInfo, new RecordItemIndex(15));
            repo.PkComTradetracker.ShopOpen_BWUStatus.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_BWUAllocated_BWUMaintenance_validation'.", repo.PkComTradetracker.ShopOpen_BWUAllocated_BWUMaintenance_validationInfo, new RecordItemIndex(16));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_BWUAllocated_BWUMaintenance_validationInfo, ShopOpen_BWUAllocated_BWUMaintenance_validation_Screenshot1, ShopOpen_BWUAllocated_BWUMaintenance_validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUAvailable' at Center", repo.PkComTradetracker.ShopOpen_BWUAvailableInfo, new RecordItemIndex(17));
            repo.PkComTradetracker.ShopOpen_BWUAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_BWUAvailableMaintenance'.", repo.PkComTradetracker.ShopOpen_BWUAvailableMaintenanceInfo, new RecordItemIndex(18));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_BWUAvailableMaintenanceInfo, ShopOpen_BWUAvailableMaintenance_Screenshot1, ShopOpen_BWUAvailableMaintenance_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(19));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(20));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_CleanedTheUnit_Yes' at Center", repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_YesInfo, new RecordItemIndex(21));
            repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_Yes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_CleanedTheUnit_No' at Center", repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_NoInfo, new RecordItemIndex(22));
            repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(23));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(24));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_PlanogramDeployed_No' at Center", repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_NoInfo, new RecordItemIndex(25));
            repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_PlanogramDeployed_Yes' at Center", repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_YesInfo, new RecordItemIndex(26));
            repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_Yes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(27));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(28));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_Yes' at Center", repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_YesInfo, new RecordItemIndex(29));
            repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_Yes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_PPOSM_validation'.", repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, new RecordItemIndex(30));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, ShopOpen_PPOSM_validation_Screenshot1, ShopOpen_PPOSM_validation_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(31));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(32));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_FreshDeployment' at Center", repo.PkComTradetracker.ShopOpen_FreshDeploymentInfo, new RecordItemIndex(33));
            repo.PkComTradetracker.ShopOpen_FreshDeployment.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_TPOSMNotAvailable' at Center", repo.PkComTradetracker.ShopOpen_TPOSMNotAvailableInfo, new RecordItemIndex(34));
            repo.PkComTradetracker.ShopOpen_TPOSMNotAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(35));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_No' at Center", repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_NoInfo, new RecordItemIndex(36));
            repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_PPOSM_validation'.", repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, new RecordItemIndex(37));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, ShopOpen_PPOSM_validation_Screenshot1_2, ShopOpen_PPOSM_validation_Screenshot1_2_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(38));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(39));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_FreshDeployment' at Center", repo.PkComTradetracker.ShopOpen_FreshDeploymentInfo, new RecordItemIndex(40));
            repo.PkComTradetracker.ShopOpen_FreshDeployment.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_TPOSMNotAvailable' at Center", repo.PkComTradetracker.ShopOpen_TPOSMNotAvailableInfo, new RecordItemIndex(41));
            repo.PkComTradetracker.ShopOpen_TPOSMNotAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_RetailerDidNotAllow' at Center", repo.PkComTradetracker.ShopOpen_RetailerDidNotAllowInfo, new RecordItemIndex(42));
            repo.PkComTradetracker.ShopOpen_RetailerDidNotAllow.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(43));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(44));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUNotAvailable' at Center", repo.PkComTradetracker.ShopOpen_BWUNotAvailableInfo, new RecordItemIndex(45));
            repo.PkComTradetracker.ShopOpen_BWUNotAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionNoButton' at Center", repo.PkComTradetracker.ChangeOptionNoButtonInfo, new RecordItemIndex(46));
            repo.PkComTradetracker.ChangeOptionNoButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUNotAvailable' at Center", repo.PkComTradetracker.ShopOpen_BWUNotAvailableInfo, new RecordItemIndex(47));
            repo.PkComTradetracker.ShopOpen_BWUNotAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(48));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUNeedsMaintenance' at Center", repo.PkComTradetracker.ShopOpen_BWUNeedsMaintenanceInfo, new RecordItemIndex(49));
            repo.PkComTradetracker.ShopOpen_BWUNeedsMaintenance.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionNoButton' at Center", repo.PkComTradetracker.ChangeOptionNoButtonInfo, new RecordItemIndex(50));
            repo.PkComTradetracker.ChangeOptionNoButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUNeedsMaintenance' at Center", repo.PkComTradetracker.ShopOpen_BWUNeedsMaintenanceInfo, new RecordItemIndex(51));
            repo.PkComTradetracker.ShopOpen_BWUNeedsMaintenance.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(52));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_BWUAvailableMaintenance'.", repo.PkComTradetracker.ShopOpen_BWUAvailableMaintenanceInfo, new RecordItemIndex(53));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_BWUAvailableMaintenanceInfo, ShopOpen_BWUAvailableMaintenance_Screenshot1_2, ShopOpen_BWUAvailableMaintenance_Screenshot1_2_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(54));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(55));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_CleanedTheUnit_Yes' at Center", repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_YesInfo, new RecordItemIndex(56));
            repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_Yes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_CleanedTheUnit_No' at Center", repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_NoInfo, new RecordItemIndex(57));
            repo.PkComTradetracker.Content.ShopOpen_CleanedTheUnit_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(58));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(59));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_PlanogramDeployed_No' at Center", repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_NoInfo, new RecordItemIndex(60));
            repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_PlanogramDeployed_Yes' at Center", repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_YesInfo, new RecordItemIndex(61));
            repo.PkComTradetracker.Content.ShopOpen_PlanogramDeployed_Yes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(62));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(63));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_Yes' at Center", repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_YesInfo, new RecordItemIndex(64));
            repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_Yes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_PPOSM_validation'.", repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, new RecordItemIndex(65));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, ShopOpen_PPOSM_validation_Screenshot1_3, ShopOpen_PPOSM_validation_Screenshot1_3_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(66));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(67));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_FreshDeployment' at Center", repo.PkComTradetracker.ShopOpen_FreshDeploymentInfo, new RecordItemIndex(68));
            repo.PkComTradetracker.ShopOpen_FreshDeployment.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_TPOSMNotAvailable' at Center", repo.PkComTradetracker.ShopOpen_TPOSMNotAvailableInfo, new RecordItemIndex(69));
            repo.PkComTradetracker.ShopOpen_TPOSMNotAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(70));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_No' at Center", repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_NoInfo, new RecordItemIndex(71));
            repo.PkComTradetracker.Content.ShopOpen_BWUPosterDeployed_No.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopOpen_PPOSM_validation'.", repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, new RecordItemIndex(72));
            Validate.ContainsImage(repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo, ShopOpen_PPOSM_validation_Screenshot1_4, ShopOpen_PPOSM_validation_Screenshot1_4_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(73));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(74));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_FreshDeployment' at Center", repo.PkComTradetracker.ShopOpen_FreshDeploymentInfo, new RecordItemIndex(75));
            repo.PkComTradetracker.ShopOpen_FreshDeployment.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_TPOSMNotAvailable' at Center", repo.PkComTradetracker.ShopOpen_TPOSMNotAvailableInfo, new RecordItemIndex(76));
            repo.PkComTradetracker.ShopOpen_TPOSMNotAvailable.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_RetailerDidNotAllow' at Center", repo.PkComTradetracker.ShopOpen_RetailerDidNotAllowInfo, new RecordItemIndex(77));
            repo.PkComTradetracker.ShopOpen_RetailerDidNotAllow.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(78));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            ConstantUserCode.UserCodeCollection.visitBWUSheetDeployed();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(80));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.RetailerDidNotAllow' at Center", repo.PkComTradetracker.RetailerDidNotAllowInfo, new RecordItemIndex(81));
            repo.PkComTradetracker.RetailerDidNotAllow.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionNoButton' at Center", repo.PkComTradetracker.ChangeOptionNoButtonInfo, new RecordItemIndex(82));
            repo.PkComTradetracker.ChangeOptionNoButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.RetailerDidNotAllow' at Center", repo.PkComTradetracker.RetailerDidNotAllowInfo, new RecordItemIndex(83));
            repo.PkComTradetracker.RetailerDidNotAllow.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ChangeOptionYesButton' at Center", repo.PkComTradetracker.ChangeOptionYesButtonInfo, new RecordItemIndex(84));
            repo.PkComTradetracker.ChangeOptionYesButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=480,Height=74}) on item 'PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.ShopOpen_RetailerBWUMaintenance'.", repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.ShopOpen_RetailerBWUMaintenanceInfo, new RecordItemIndex(85));
            Validate.ContainsImage(repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.ShopOpen_RetailerBWUMaintenanceInfo, ShopOpen_RetailerBWUMaintenance_Screenshot1, ShopOpen_RetailerBWUMaintenance_Screenshot1_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.DSRNotVisiting' at Center", repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.DSRNotVisitingInfo, new RecordItemIndex(86));
            repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.DSRNotVisiting.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.SchemeNotOffered' at Center", repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.SchemeNotOfferedInfo, new RecordItemIndex(87));
            repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.SchemeNotOffered.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.IncentiveNotPaid' at Center", repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.IncentiveNotPaidInfo, new RecordItemIndex(88));
            repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.IncentiveNotPaid.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.Others' at Center", repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.OthersInfo, new RecordItemIndex(89));
            repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.Others.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(90));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(91));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(92));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_ValidateOKButton' at Center", repo.PkComTradetracker.ShopOpen_ValidateOKButtonInfo, new RecordItemIndex(93));
            repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.ShopOpen_BWUAllocatedTakePhoto' at Center", repo.PkComTradetracker.ShopOpen_BWUAllocatedTakePhotoInfo, new RecordItemIndex(94));
            repo.PkComTradetracker.ShopOpen_BWUAllocatedTakePhoto.Touch();
            Delay.Milliseconds(500);
            
            ConstantUserCode.UserCodeCollection.TakePhoto();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PkComTradetracker.TPOSM_ButtonDone' at Center", repo.PkComTradetracker.TPOSM_ButtonDoneInfo, new RecordItemIndex(96));
            repo.PkComTradetracker.TPOSM_ButtonDone.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(97));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{BACK}' press on 'PkComTradetracker'.", repo.PkComTradetracker.SelfInfo, new RecordItemIndex(98));
            repo.PkComTradetracker.Self.PressKeys("{BACK}");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage ShopOpen_BWUMaintenance_validation_Screenshot1
        { get { return repo.PkComTradetracker.ShopOpen_BWUMaintenance_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_BWUMaintenance_validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_BWUAllocated_BWUMaintenance_validation_Screenshot1
        { get { return repo.PkComTradetracker.ShopOpen_BWUAllocated_BWUMaintenance_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_BWUAllocated_BWUMaintenance_validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_BWUAvailableMaintenance_Screenshot1
        { get { return repo.PkComTradetracker.ShopOpen_BWUAvailableMaintenanceInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_BWUAvailableMaintenance_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_PPOSM_validation_Screenshot1
        { get { return repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_PPOSM_validation_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_PPOSM_validation_Screenshot1_2
        { get { return repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_PPOSM_validation_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_BWUAvailableMaintenance_Screenshot1_2
        { get { return repo.PkComTradetracker.ShopOpen_BWUAvailableMaintenanceInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_BWUAvailableMaintenance_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_PPOSM_validation_Screenshot1_3
        { get { return repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_PPOSM_validation_Screenshot1_3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_PPOSM_validation_Screenshot1_4
        { get { return repo.PkComTradetracker.ShopOpen_PPOSM_validationInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_PPOSM_validation_Screenshot1_4_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ShopOpen_RetailerBWUMaintenance_Screenshot1
        { get { return repo.PkComTradetracker.ShopkeeperDidNotAllowRemarksListScreen.ShopOpen_RetailerBWUMaintenanceInfo.GetScreenshot1(new Rectangle(0, 0, 480, 74)); } }

        Imaging.FindOptions ShopOpen_RetailerBWUMaintenance_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}