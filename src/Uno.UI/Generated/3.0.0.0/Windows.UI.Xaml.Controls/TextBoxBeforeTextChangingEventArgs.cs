#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextBoxBeforeTextChangingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TextBoxBeforeTextChangingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TextBoxBeforeTextChangingEventArgs", "bool TextBoxBeforeTextChangingEventArgs.Cancel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string NewText
		{
			get
			{
				throw new global::System.NotImplementedException("The member string TextBoxBeforeTextChangingEventArgs.NewText is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxBeforeTextChangingEventArgs.NewText.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxBeforeTextChangingEventArgs.Cancel.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextBoxBeforeTextChangingEventArgs.Cancel.set
	}
}
