#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	public delegate void TextControlPasteEventHandler(object @sender, global::Windows.UI.Xaml.Controls.TextControlPasteEventArgs @e);
	#endif
}
