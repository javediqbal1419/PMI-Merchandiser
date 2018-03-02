/*
 * Created by Ranorex
 * User: Fahad Shah
 * Date: 2/18/2018
 * Time: 12:36 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Linq;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TradeTrackerProject.ConstantUserCode
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UserCodeCollection
    {
    	public static TradeTrackerProject.TradeTrackerProjectRepository repo = TradeTrackerProject.TradeTrackerProjectRepository.Instance;
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void TakePhoto()
    	{
    		repo.PkComTradetracker.TPOSM_TakePhotoButton.Touch();
        	Delay.Seconds(6);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void selectCurrentDay()
    	{
    		string day = System.DateTime.Now.DayOfWeek.ToString();
        	if(day.Equals("Monday")){
    			repo.PkComTradetracker.List.Monday.Touch();
        	}
        	else if(day.Equals("Tuesday")){
    			repo.PkComTradetracker.List.Tuesday.Touch();
        	}
        	else if(day.Equals("Wednessday")){
    			repo.PkComTradetracker.List.Wednessday.Touch();
        	}
        	else if(day.Equals("Thursday")){
    			repo.PkComTradetracker.List.Thursday.Touch();
        	}
        	else if(day.Equals("Friday")){
    			repo.PkComTradetracker.List.Friday.Touch();
        	}
        	else if(day.Equals("Saturday")){
    			repo.PkComTradetracker.List.Saturday.Touch();
        	}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void chooseNonTKShopFromList()
    	{
    		string lastitembeforeswipe = "";
    		string lastitemafterswipe = "";
    		bool flag = false;
    		var shopslist = repo.PkComTradetracker.ShopsList.Children.ToList();
	    	foreach(var shop in shopslist){
        		var shopname = shop.Children.ToList();
        		string shoptype = Convert.ToString(shopname[1]);
        		if(shoptype.Contains("Non-TK")){
        			shop.Touch();
        			TradeTrackerProject.TestCases.Non_TK_ShopOpen.VisitShopOpen.Start();
        			flag = true;
        			break;
        		}
        	}
    		if(flag != true){
    			try{
    				while(true){
			    		var lastitemcontainerbeforeswipe = repo.PkComTradetracker.ShopsList.Children.Last();
				    	var containeritemsbeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
				    	lastitembeforeswipe = Convert.ToString(containeritemsbeforeswipe[1]);
				    	repo.PkComTradetracker.ShopsList.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
		    			Delay.Milliseconds(2000);
			            var lastitemcontainerafterswipe = repo.PkComTradetracker.ShopsList.Children.Last();
			            var containeritemsafterswipe = lastitemcontainerafterswipe.Children.ToList();
			            lastitemafterswipe = Convert.ToString(containeritemsafterswipe[1]);
			            if(lastitembeforeswipe == lastitemafterswipe){
			            	TradeTrackerProject.TestCases.TK_ShopOpen.ChooseTKShop.Start();
			            	break;
			            }
			            else{
			            	if(lastitemafterswipe.Contains("Non-TK")){
				           		lastitemcontainerafterswipe.Touch();
				           		TradeTrackerProject.TestCases.Non_TK_ShopOpen.VisitShopOpen.Start();
				            	break;
				           	}
			    		}
	            	}
    			}
    			catch{
    			}
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void chooseTKShopFromList()
    	{
    		string lastitembeforeswipe = "";
    		string lastitemafterswipe = "";
    		bool flag = false;
    		var shopslist = repo.PkComTradetracker.ShopsList.Children.ToList();
	    	foreach(var shop in shopslist){
		       	var shopname = shop.Children.ToList();
		       	string shoptype = Convert.ToString(shopname[1]);
		       	if(shoptype.Contains("TK") && !shoptype.Contains("Non-TK")){
		        	shop.Touch();
		        	TradeTrackerProject.TestCases.TK_ShopOpen.VisitShopOpen.Start();
		        	flag = true;
		        	break;
		        }
        	}
    		if(flag != true){
    			try{
    				while(true){
			    		var lastitemcontainerbeforeswipe = TradeTrackerProjectRepository.Instance.PkComTradetracker.ShopsList.Children.Last();
				    	var containeritemsbeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
				    	lastitembeforeswipe = Convert.ToString(containeritemsbeforeswipe[1]);
				    	repo.PkComTradetracker.ShopsList.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
		    			Delay.Milliseconds(2000);
			            var lastitemcontainerafterswipe = repo.PkComTradetracker.ShopsList.Children.Last();
			            var containeritemsafterswipe = lastitemcontainerafterswipe.Children.ToList();
			            lastitemafterswipe = Convert.ToString(containeritemsafterswipe[1]);
			            if(lastitembeforeswipe == lastitemafterswipe){
			            	break;
			            }
			            else{
			            	if(lastitemafterswipe.Contains("TK") && !lastitemafterswipe.Contains("Non-TK")){
				           		lastitemcontainerafterswipe.Touch();
					        	TradeTrackerProject.TestCases.TK_ShopOpen.VisitShopOpen.Start();
				            	break;
				           	}
			    		}
	            	}
    			}
    			catch{
    			}
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void countTKShopModules()
    	{
    		int tkshopmodulescount = repo.PkComTradetracker.ShopModules.Children.Count;
        	if((tkshopmodulescount-1) == 4){
    			TradeTrackerProject.TestCases.TK_ShopOpen.BWUMaintenance.Start();
    			Delay.Milliseconds(500);
        	}
    		else if((tkshopmodulescount-1) == 3){
    			TradeTrackerProject.TestCases.TK_ShopOpen.ComplianceCheck.Start();
    			Delay.Milliseconds(500);
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void countNonTKShopModules()
    	{
    		int nontkshopmodulescount = repo.PkComTradetracker.ShopModules.Children.Count;
    		if((nontkshopmodulescount-1) == 3){
    			TradeTrackerProject.TestCases.Non_TK_ShopOpen.BWUMaintenance.Start();
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void displayShopFascia()
    	{
    		repo.PkComTradetracker.ShopFascia.Touch();
    		Delay.Seconds(3);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitBWUSheetDeployed()
    	{
    		var bwu = repo.PkComTradetracker.BWUContainer.Children.Last();
    		if(bwu.Visible){
    			repo.PkComTradetracker.Self.PressKeys("{BACK}");
    			Delay.Milliseconds(500);
    			repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
    			Delay.Milliseconds(500);
    			repo.PkComTradetracker.Content.ShopOpen_BWUSheetDeployed_Yes.Touch();
    			Delay.Milliseconds(500);
    			repo.PkComTradetracker.Self.PressKeys("{BACK}");
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_FreshDeployment.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_TPOSMNotAvailable.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.Self.PressKeys("{BACK}");
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.Content.ShopOpen_BWUSheetDeployed_No.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.Self.PressKeys("{BACK}");
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_FreshDeployment.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_TPOSMNotAvailable.Touch();
            	Delay.Milliseconds(500);
            	repo.PkComTradetracker.ShopOpen_RetailerDidNotAllow.Touch();
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadAndEditTPOSMFields()
    	{
    		int tposmcount = repo.PkComTradetracker.Linear.TPOSMLoading_Container.Children.Count;
    		var totaltposm = repo.PkComTradetracker.Linear.TPOSMLoading_Container.Children.ToList();
    		for(int i=1; i<=tposmcount-1; i=i+3){
    			var tposmfields = totaltposm[i].Children.ToList();
    			tposmfields[1].Element.SetAttributeValue("Text" , "");
    			tposmfields[1].Element.SetAttributeValue("Text" , "12345678");
            	Delay.Milliseconds(100);
    		}
    	}
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitTPOSMItems(string tposmtext)
    	{
    		if(tposmtext.Contains("Key Message Communication") || tposmtext.Contains("Trade Letter")){
    				repo.PkComTradetracker.Self.PressKeys("{BACK}");
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_Option1.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_Option2.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionNoButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_Option2.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.Self.PressKeys("{BACK}");
    				Delay.Milliseconds(500);
    			}
    			else
    			{
    				repo.PkComTradetracker.Self.PressKeys("{BACK}");
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_Option1.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_AndroidWidgetEditText_EnterQuantity.Element.SetAttributeValue("Text","5");
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_EnterQuantityOkButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_Option2.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionNoButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ShopOpen_Option2.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.List2.ShopOpen_Option3.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionNoButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.List2.ShopOpen_Option3.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.List2.ShopOpen_Option4.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionNoButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.List2.ShopOpen_Option4.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.List2.ShopOpen_Option5.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionNoButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.List2.ShopOpen_Option5.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    				Delay.Milliseconds(500);
    				repo.PkComTradetracker.Self.PressKeys("{BACK}");
    				Delay.Milliseconds(500);
    			}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitAllTPOSM()
    	{
    		var tposmlist = repo.PkComTradetracker.List4.TPOSMList.Children.ToList();
    		for(int i=0; i<tposmlist.Count; i++){
    			var tposm = tposmlist[i].Children.ToList();
    			string tposmtext = Convert.ToString(tposm[1]);
    			repo.PkComTradetracker.Self.PressKeys("{BACK}");
    			Delay.Milliseconds(500);
    			repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
    			Delay.Milliseconds(500);
    			tposmlist[i].Touch();
    			Delay.Milliseconds(500);
    			visitTPOSMItems(tposmtext); // call function to visit all the items of TPOSM
    		}
    		try{
    			while(true){
	    			var lastitemcontainerbeforeswipe = TradeTrackerProjectRepository.Instance.PkComTradetracker.List4.TPOSMList.Children.Last();
			    	var containeritemsbeforeswipe = lastitemcontainerbeforeswipe.Children.ToList();
			    	var lastitembeforeswipe = Convert.ToString(containeritemsbeforeswipe[1]);
			    	TradeTrackerProjectRepository.Instance.PkComTradetracker.ShopsList.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", ".147"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
	    			Delay.Milliseconds(2000);
		            var lastitemcontainerafterswipe = TradeTrackerProjectRepository.Instance.PkComTradetracker.List4.TPOSMList.Children.Last();
		            var containeritemsafterswipe = lastitemcontainerafterswipe.Children.ToList();
		            var lastitemafterswipe = Convert.ToString(containeritemsafterswipe[1]);
		            if(lastitembeforeswipe == lastitemafterswipe){
		            	break;
		            }
		            else{
		            	TradeTrackerProjectRepository.Instance.PkComTradetracker.Self.PressKeys("{BACK}");
		    			Delay.Milliseconds(500);
		    			TradeTrackerProjectRepository.Instance.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
		    			Delay.Milliseconds(500);
		    			lastitemcontainerafterswipe.Touch();
		    			Delay.Milliseconds(500);
		    			visitTPOSMItems(lastitemafterswipe);
		    		}
	    		}
    		}
    		catch{
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void validateTradeTracker()
    	{
    		Validate.AttributeEqual(repo.PkComTradetracker.TradeTracker_validationInfo, "Text", "Trade Tracker");
    		Delay.Seconds(10);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void CheckIn_ListView()
    	{
    		int countlist = repo.PkComTradetracker.CheckIn_ListView.Children.Count;
    		if(countlist == 2){
    			repo.PkComTradetracker.ShopOpen.Touch();
    		}
    	}
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadTKComplianceCheck()
    	{
    		TradeTrackerProject.TestCases.TK_ShopOpen.ComplianceCheck.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadTKAvailabilityCheck()
    	{
    		TradeTrackerProject.TestCases.TK_ShopOpen.AvailabilityCheck.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadTKTPOSM()
    	{
    		TradeTrackerProject.TestCases.TK_ShopOpen.TPOSMApplication.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadNonTKAvailabilityCheck()
    	{
    		TradeTrackerProject.TestCases.Non_TK_ShopOpen.AvailabilityCheck.Start();
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void loadNonTKTPOSM()
    	{
    		TradeTrackerProject.TestCases.Non_TK_ShopOpen.TPOSMApplication.Start();
    	}
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitAvailabilityCheck()
    	{
    		var listcontainer = repo.PkComTradetracker.Linear1.ShopOpen_AvailabilityCheck_Container.Children.ToList();
    		for(int i=1; i<listcontainer.Count; i=i+3){
    			var availabilitychecklist = listcontainer[i];
	    		var availabilitychecklistcontainer = availabilitychecklist.Children.ToList();
	    		var availabilitycheckitems = availabilitychecklistcontainer[0];
	    		var availabilitycheckitem = availabilitycheckitems.Children.ToList();
	    		repo.PkComTradetracker.Self.PressKeys("{BACK}");
	   			Delay.Milliseconds(500);
	    		repo.PkComTradetracker.ShopOpen_ValidateOKButton.Touch();
	    		Delay.Milliseconds(500);
	    		for(int j=0; j<availabilitycheckitem.Count; j++){
	    			availabilitycheckitem[j].Touch();
	    			Delay.Milliseconds(500);
	    		}
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void setPlanogram()
    	{
    		var planogram = repo.PkComTradetracker.UnitPlanogramScreen.Set_Planogram.Children.ToList();
    		planogram[0].Touch();
    		Delay.Milliseconds(500);
    		repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    		Delay.Milliseconds(500);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void visitShelfDisplayRemarks()
    	{
    		var shelfdisplayremarks = repo.PkComTradetracker.ComplianceCheck_ShelfDisplayRemarks.Children.ToList();
    		for(int i=0; i<shelfdisplayremarks.Count; i++){
    			shelfdisplayremarks[i].Touch();
    			Delay.Milliseconds(500);
    			if(i>0){
    				repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    				Delay.Milliseconds(500);
    			}
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void checkShopVisited()
    	{
    		try{
    			repo.PkComTradetracker.ChangeOptionYesButton.Touch();
    			Delay.Milliseconds(500);
    		}
    		catch{
    		}
    	}
    }
    
}
