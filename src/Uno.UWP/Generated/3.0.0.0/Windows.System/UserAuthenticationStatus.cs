#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum UserAuthenticationStatus 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		Unauthenticated,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		LocallyAuthenticated,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		RemotelyAuthenticated,
		#endif
	}
	#endif
}
