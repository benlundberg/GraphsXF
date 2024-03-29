﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GraphsXF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingView : ContentView
    {
        public LoadingView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty IsRunningProperty = BindableProperty.Create(
            propertyName: "IsRunning",
            returnType: typeof(bool),
            declaringType: typeof(LoadingView),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay);

        public bool IsRunning
        {
            get => (bool)GetValue(IsRunningProperty);
            set => SetValue(IsRunningProperty, value);
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(LoadingView),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.TwoWay);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public Color TextColor { get; set; }
        public Color Color { get; set; }
    }
}
