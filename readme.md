In this tutorial I will demonstrate how to make your own custom control for Universal Windows Platform application. This is very handy way of making your app more modular and responsive. For this tutorial I will make "Speaker" control, for some of our conference or event App.  

First we need to create new UWP App:  

Steps: **File -> New -> Project -> Visual C# -> Blank App (Universal Windows) -> Type new name -> Ok**  

![](https://4.bp.blogspot.com/-BPkZtXr7DfM/V8J_GrzjD1I/AAAAAAAAB0M/EMNESLxjCl0Jx3jnGp-MSo54n0PYV2vewCLcB/s1600/uwp_1.png)

This was pretty easy so we can move to a "hard" part.  

I will create three folders in my project, one called Views, one called CustomControls and of course Models folder for my classes, this is not necessary but I will make those two folders to separate my views and custom controls.  

In my Views folder I will add new blank page called **SpeakersView.xaml** and I will add new class in my Models folder called Speaker which looks like this:  

![](https://3.bp.blogspot.com/-I9-9nRWcmr0/V8KFzSSZEeI/AAAAAAAAB0c/UmppTqh80pU_h9Hf71vj6-ry61HfwjsYACLcB/s1600/uwp_2.png)

This is our simple Speaker class with basic properties, now we will try to make our visual presentation for Speaker in SpeakerView.xaml.  

When you have need to share same ui control across your app there are two ways to do that. First one is to combine default controls to make our own custom control, as I mentioned I will make Speaker control for one of my apps, and the XAML and code behind will look like this:  

![](https://1.bp.blogspot.com/-YcayGHNNgZc/V8KP96eV8ZI/AAAAAAAAB0s/oVXvssyFoO0ci6fKPOunk8lAxNp_Y7axACLcB/s1600/Speaker_wup.png)

And code behind **SpeakersView.xaml.cs**  

![](https://1.bp.blogspot.com/-Nf4uBlsdCVw/V8KVjh8MckI/AAAAAAAAB08/uXMyZFRXygcI_mFC2XpjXBQRWNmL3o5VgCLcB/s1600/code_behind.png)

When I run this code I will get this kind of result:  

![](https://2.bp.blogspot.com/-KEll6cIjxsU/V8KdAFkOkKI/AAAAAAAAB1M/M6abR5chL-0P1ddA8e6xTFZQ4se4eahvACLcB/s1600/custom_control_uwp.png)

For those who are not familiar with binding I will try to explain as short as possible. In my XAML view I create one GridView with DataTemplate, everything inside of data template will represent the items for my GridView. I used these couple of built in controls to make this "layout" for my speaker... and the data is in code behind class in my ObservableCollection of Speakers, as you can see I am using just one element in my list but if I want to have multiple speakers I do not need to change code in my XAML view, I just need to add new element to a ObservableCollection and new Speaker will appear in View.  

Photo, first name, last name and company I am binding it to a Speaker model class which use ObservableCollection as a data and Speaker as a Model for this "properties".  

Now everything looks great but what if I need to use this Speaker layout in again my App or I have similar project that I work on it do I want to write this same lines of code again? Answer is no. In order to make this modular and more practical I will create my own custom control which will be easier to use sometimes again.  

### Create custom control:

I will right click on my folder **CustomControls -> Add -> New item**

On a left side choose **XAML** and select **UserControl,** for name I will use **SpeakerControl** and click **Add**

![](https://3.bp.blogspot.com/-H2Z_DcbWeRY/V8KgEyJi_8I/AAAAAAAAB1Y/kmhkVGYxkMcnanHV8pBTC1hg1cGl6qmIACLcB/s1600/custom_control_uwp_2.png)

We can copy xaml code which was representing our speaker in SpeakerView.xaml to this SpeakerControl.xaml inside of Grid. This is not it, we need to make some changes and add some code to make this work.  

Now we have to make dependency properties for our controls in side of stack panel we need these for data binding. Go to **SpeakerControl.xaml.cs** in order to create dependency property we can use code snippet: **propdp + tab + tab**  
When you hit that code snippet you will see that it will generate one public property for you and one static readonly dependency property which we can use to bind data to our controls inside of our custom controls.  

And it looks like this:  

![](https://1.bp.blogspot.com/-LdR2TnQs5ns/V8Ku9eNc_NI/AAAAAAAAB1o/CdCmTMVVansvEiCeXHJN97zxmPx87GRKwCLcB/s1600/custom_control_uwp_3.png)

In the Register part you can see that we define, name, type for our property, and the type of class which this property belong. After you make dependency properties for all the controls in side of our custom control, make sure to do build your project. **It is very important to build project for our next steps.**  
Now we can go to XAML and make some edits to our controls, basically we need to bind content of our controls (source, text...) to the dependency properties like this:  

![](https://1.bp.blogspot.com/-JkcJImcFnE0/V8KzXaF6N9I/AAAAAAAAB10/-YjpQ0SIcIERRc49s1PHPfDz1plRZU79wCLcB/s1600/uwp_3.png)

You can set this binding via UI in Visual Studio, but for me this is simple and easy. As you can see we are binding our content values to a dependency properties and we are using ElementName property and set it to userControl which is default one for user controls and it is defined here at the top:  

![](https://3.bp.blogspot.com/-mu1p5kfMDSE/V8K0DCr7nTI/AAAAAAAAB14/E-tYfLNUMz8Ln2ca-PS4h9fPPpDr3zcKACLcB/s1600/uwp_4.png)

After this we can go back in our SpeakerView.xaml and instead of that code block we can now use our new custom control like this.  

First we need to add "reference" to our "**CustomControls**" folder like this:  

![](https://4.bp.blogspot.com/-OuQVUp7EH_0/V8K1cRSXfoI/AAAAAAAAB2I/x5jh4jwpKI4A4f2ob6kmdL7hbcvlkVSpwCLcB/s1600/uwp_5.png)

after that we can use our custom control in XAML like this:  

![](https://1.bp.blogspot.com/-IJfREFGPV9U/V8K6dhnG39I/AAAAAAAAB2Y/2VkfoKs8kHwnLAHcQqFmE4ruuddPN5HrgCLcB/s1600/uwp_6.png)

In my code behind at speakersList I will add one more speaker to show that binding and data template works with custom control.  

![](https://4.bp.blogspot.com/-GxJOjcTnVAo/V8LAsrsVSQI/AAAAAAAAB2o/FlEAlv0aD8I3haJKI86NQNsKeViX03f0gCLcB/s1600/uwp_7.png)

And now my app looks like this:  

![](https://3.bp.blogspot.com/-ARQR1rfS_i8/V8LBcUylOyI/AAAAAAAAB2s/papDDDsGLFQo3kMOwvXXSS5majvbtNG5gCLcB/s1600/uwp_8.png)

And that is it, now we have our own custom XAML control and we can use it just like other controls, to add more properties to it, follow steps with Dependency Properties and you can add all kinds of properties in order to make it adaptive and responsive... hope you find this tutorial helpful.
