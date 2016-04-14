#JDI UI Test Automation Framework

Copyright (c) 2016, EPAM Systems

License: GPL v3. [GPL License](http://www.gnu.org/licenses)

##Introduction

JDI – is the test Framework for automation of UI applications testing. It extends Page Objects design pattern and introduces lot of additional elements with implementation of its common usages.

Framework used concept “Easy things should be easy, and hard things should be possible” Larry Wall (c). 

So all elements and abilities has default realization that mostly used, but in case your application used some actions in different way, you can override this behavior on any level (just for this element, for all elements with same type or even all elements actions scenarios usage). 

Similar you can use any kind of external tools and frameworks for related functionality (different loggers, reporting tools, drivers test runners and asserters)

We try to do test process easier and full of joy! :)

## How to use
### Site
```Java
@JSite(domain = "https://www.epam.com")
public class EpamSite extends WebSite {

    @JPage(url = "/", title = "EPAM | Software Product Development Services")
    public static HomePage homePage;
    @JPage(url = "/careers", title = "Careers")
    public static CareerPage careerPage;
    ...
    
    @FindBy(css = ".tile-menu>li>a")              // Menu with limited list of options described by enum Header menu
    public static Menu<HeaderMenu> headerMenu; 
    @FindBy(css = ".tile-menu>li>a")              // List of elements accessible only by index
    public static List<Label> listMenu;
    @FindBy(css = ".tile-menu>li>a")              // List of elements with ability to access by name
    public static Elements<Label> listMenu;
}
```
### Page
```Java
public class CareerPage extends WebPage {
    @FindBy(className = "job-search-input")       // Simple Text field
    public ITextField keywords;
    
    public IDropDown<JobCategories> category = new Dropdown<>(  // Complex Dropdown with two locators
        By.className("multi-select-filter"), 
        By.className("blue-checkbox-label"));
    @FindBy(className = "career-location-box")    // Simple Dropdown
    public IDropDown<Locations> city;

    @FindBy(className = "job-search-button")      // Simple Button
    public IButton selectButton;

}
```
### Form
```Java
public class AddCVForm extends Form<Attendee> {  
    @FindBy(css = "[placeholder='First Name']") private ITextField name;
    @FindBy(css = "[placeholder='Last Name']")  private ITextField lastName;
    @FindBy(css = "[placeholder='Email']")      private ITextField email;
    private IDropDown country = new Dropdown<>(
        By.cssSelector(".country-wrapper .arrow"), 
        By.xpath("//*[contains(@id,'select-box-applicantCountry')]//li"));
    private IDropDown city = new Dropdown<>(
        By.cssSelector(".city-wrapper .arrow"), 
        By.xpath("//*[contains(@id,'select-box-applicantCity')]//li"));
    @FindBy(css = ".file-upload")               private RFileInput cv;
    @FindBy(css = ".comment-input")             private ITextArea comment;

    @FindBy(xpath = "//*[.='Submit']")          private IButton submit;
    @FindBy(xpath = "//*[.='Cancel']")          private IButton cancel;

}
```

## How to add
###Java (Maven):
####Web:
```xml
<dependency>
    <groupId>com.epam.jdi</groupId>
    <artifactId>jdi-uitest-web</artifactId>
    <version>1.0.3-SNAPSHOT</version>
</dependency>
```
####Mobile:
```xml
<dependency>
    <groupId>com.epam.jdi</groupId>
    <artifactId>jdi-uitest-mobile</artifactId>
    <version>1.0.3-SNAPSHOT</version>
</dependency>
```
####Desktop:
```xml
<dependency>
    <groupId>com.epam.jdi</groupId>
    <artifactId>jdi-uitest-gui</artifactId>
    <version>1.0.3-SNAPSHOT</version>
</dependency>
```

###.Net 
Add Nuget package "JDI.UITestFramework"

##Examples
[Java tests](https://github.com/epam/JDI/tree/master/Java/Tests)

[C# tests](https://github.com/epam/JDI/tree/master/C%23.Net/Tests)

##Methods Documentation
[Java](https://github.com/epam/JDI/blob/master/JDI_UI_TEST_Framework.docx )

##Links

VK: https://vk.com/jdi_framework

You can ask your questions on StackOverflow with [![htmlelements](https://img.shields.io/badge/stackoverflow-jdiframework-orange.svg?style=flat)](http://stackoverflow.com/questions/tagged/jdiframework) tag.
##Contacts:

Mail: roman_iovlev@epam.com

Skype: roman.iovlev

