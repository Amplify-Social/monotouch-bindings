using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace TwitterTextLib {

    [BaseType (typeof (NSObject))]
    public partial interface TwitterTextEntity {

        [Export ("type")]
        TwitterTextEntityType Type { get; set; }

        [Export ("range", ArgumentSemantic.Assign)]
        NSRange Range { get; set; }

        [Static, Export ("entityWithType:range:")]
        TwitterTextEntity EntityWithType (TwitterTextEntityType type, NSRange range);
    }


    [BaseType (typeof (NSObject))]
    public partial interface TwitterText {

        [Static, Export ("entitiesInText:")]
        TwitterTextEntity [] EntitiesInText (string text);

        [Static, Export ("URLsInText:")]
        TwitterTextEntity [] URLsInText (string text);

        [Static, Export ("hashtagsInText:checkingURLOverlap:")]
        TwitterTextEntity [] HashtagsInText (string text, bool checkingURLOverlap);

        [Static, Export ("symbolsInText:checkingURLOverlap:")]
        TwitterTextEntity [] SymbolsInText (string text, bool checkingURLOverlap);

        [Static, Export ("mentionedScreenNamesInText:")]
        TwitterTextEntity [] MentionedScreenNamesInText (string text);

        [Static, Export ("mentionsOrListsInText:")]
        TwitterTextEntity [] MentionsOrListsInText (string text);

        [Static, Export ("repliedScreenNameInText:")]
        TwitterTextEntity RepliedScreenNameInText (string text);

        [Static, Export ("tweetLength:")]
        int TweetLength (string text);

        [Static, Export ("tweetLength:httpURLLength:httpsURLLength:")]
        int TweetLength (string text, int httpURLLength, int httpsURLLength);

        [Static, Export ("remainingCharacterCount:")]
        int RemainingCharacterCount (string text);

        [Static, Export ("remainingCharacterCount:httpURLLength:httpsURLLength:")]
        int RemainingCharacterCount (string text, int httpURLLength, int httpsURLLength);
    }
}