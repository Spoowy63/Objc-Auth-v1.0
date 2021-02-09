static void didFinishLaunching(CFNotificationCenterRef center, void *observer, CFStringRef name, const void *object, CFDictionaryRef info) {

#define timer(sec) dispatch_after(dispatch_time(DISPATCH_TIME_NOW, sec * NSEC_PER_SEC), dispatch_get_main_queue(), ^

NSUserDefaults *check;
check = [NSUserDefaults standardUserDefaults];


timer(5) {

// you can change window width here
SCLAlertView *alert = [[SCLAlertView alloc] initWithNewWindowWidth:250];



alert.customViewColor = [UIColor colorWithRed:0.96 green:0.84 blue:0.65 alpha:1.0];
alert.showAnimationType = SCLAlertViewShowAnimationFadeIn;
alert.hideAnimationType = SCLAlertViewHideAnimationFadeOut;
alert.shouldDismissOnTapOutside = NO;
alert.backgroundType = SCLAlertViewBackgroundBlur;
alert.cornerRadius = 10.0f;
alert.backgroundViewColor = [UIColor colorWithRed:0.04 green:0.16 blue:0.24 alpha:1.0];

SCLAlertView *bad = [[SCLAlertView alloc] initWithNewWindowWidth:300];

bad.customViewColor = [UIColor colorWithRed:0.96 green:0.84 blue:0.65 alpha:1.0];
bad.showAnimationType = SCLAlertViewShowAnimationFadeIn;
alert.hideAnimationType = SCLAlertViewHideAnimationFadeOut;
bad.shouldDismissOnTapOutside = NO;
bad.backgroundType = SCLAlertViewBackgroundBlur;
bad.cornerRadius = 10.0f;
bad.backgroundViewColor = [UIColor colorWithRed:0.04 green:0.16 blue:0.24 alpha:1.0];

SCLAlertView *nice = [[SCLAlertView alloc] initWithNewWindowWidth:250];


nice.customViewColor = [UIColor colorWithRed:0.96 green:0.84 blue:0.65 alpha:1.0];
nice.showAnimationType = SCLAlertViewShowAnimationFadeIn;
alert.hideAnimationType = SCLAlertViewHideAnimationFadeOut;
nice.shouldDismissOnTapOutside = NO;
nice.backgroundType = SCLAlertViewBackgroundBlur;
nice.cornerRadius = 10.0f;
nice.backgroundViewColor = [UIColor colorWithRed:0.04 green:0.16 blue:0.24 alpha:1.0];


[nice addButton: @"Visit Github.com/Spoowy63 For More!" validationBlock: ^BOOL {
[[UIApplication sharedApplication] openURL: [NSURL URLWithString:@"https://github.com/Spoowy63"]];
BOOL shouldClosePopup = false;
return shouldClosePopup;
} actionBlock:^{}];
    [nice addButton: @"Thanks" actionBlock: ^(void) {
      timer(1) {
        setupMenu();
      });
    }];    


NSString *loggedin = [check stringForKey:@"loggedin"];
timer(1) {
if([loggedin isEqualToString:@"1"]) {
[nice showSuccess:@"You're Logged In" subTitle:@"Telegram: FlipFlop7 \n" closeButtonTitle:nil duration:999999999.0f];
[nice.view setTintColor:[UIColor yellowColor]];

}
});

UITextField *text1 = [alert addTextField:@"Username"];

UITextField *text2 = [alert addTextField:@"Password"];


[alert addButton: @"Visit Github.com/Spoowy63 For More!" validationBlock: ^BOOL {
[[UIApplication sharedApplication] openURL: [NSURL URLWithString:@"https://github.com/Spoowy63"]];
BOOL shouldClosePopup = false;
return shouldClosePopup;
} actionBlock:^{}];



[alert addButton:@"Unlock" actionBlock:^ (void) {
// you can use base64 or my objc string obfuscator to encode the username and password.
if ([text1.text isEqualToString:@"FlipFlop"] && [text2.text isEqualToString:@"Spoowy"]) {
[check setObject:@"1" forKey:@"loggedin"];
[check synchronize];
timer(1) {
[nice showSuccess:@"Success" subTitle:@"Telegram: FlipFlop7 \n" closeButtonTitle:nil duration:999999999.0f];
});
}
else
{
[bad showError:@"Wrong Username or Password" subTitle:@"\n Game will crash now. \n After that you can try again" closeButtonTitle:nil duration:999999999.0f];
timer(2) {
exit(0);
});
}
}];





if(![loggedin isEqualToString:@"1"]) {
NSData* data = [[NSData alloc] initWithBase64EncodedString:@"BASE64 IMAGE HERE " options:0];
UIImage* customAlertImage = [UIImage imageWithData:data];   

[alert showCustom:alert image:customAlertImage color:[UIColor redColor] title:@"FlipFlop" subTitle:@"\n Enter a Username & Passoword\n" closeButtonTitle:nil duration:9999999999.0f];
}
  });
}


%ctor {
  CFNotificationCenterAddObserver(CFNotificationCenterGetLocalCenter(), NULL, &didFinishLaunching, (CFStringRef)UIApplicationDidFinishLaunchingNotification, NULL, CFNotificationSuspensionBehaviorDeliverImmediately);
}
