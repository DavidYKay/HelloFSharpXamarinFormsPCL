﻿using System;

using Xamarin.Forms;
using HelloFSharpXamarinFormsPortable.FSharp;

namespace HelloFSharpXamarinFormsPortable
{
  public class App : Application
  {
    public App ()
    {
      // The root page of your application
      MainPage = new ContentPage {
        Content = new StackLayout {
          VerticalOptions = LayoutOptions.Center,
          Children = {
            new Label {
              XAlign = TextAlignment.Center,
              Text = new HelloFSharp().HelloWorld,
            }
          }
        }
      };
    }

    protected override void OnStart ()
    {
      // Handle when your app starts
    }

    protected override void OnSleep ()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume ()
    {
      // Handle when your app resumes
    }
  }
}

