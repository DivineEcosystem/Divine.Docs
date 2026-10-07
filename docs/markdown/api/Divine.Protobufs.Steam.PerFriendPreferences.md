# <a id="Divine_Protobufs_Steam_PerFriendPreferences"></a> Class PerFriendPreferences

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class PerFriendPreferences : IMessage<PerFriendPreferences>, IEquatable<PerFriendPreferences>, IDeepCloneable<PerFriendPreferences>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PerFriendPreferences](Divine.Protobufs.Steam.PerFriendPreferences.md)

#### Implements

IMessage<PerFriendPreferences\>, 
[IEquatable<PerFriendPreferences\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<PerFriendPreferences\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<PerFriendPreferences\>\(PerFriendPreferences, params PerFriendPreferences\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_PerFriendPreferences__ctor"></a> PerFriendPreferences\(\)

```csharp
public PerFriendPreferences()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences__ctor_Divine_Protobufs_Steam_PerFriendPreferences_"></a> PerFriendPreferences\(PerFriendPreferences\)

```csharp
public PerFriendPreferences(PerFriendPreferences other)
```

#### Parameters

`other` [PerFriendPreferences](Divine.Protobufs.Steam.PerFriendPreferences.md)

## Fields

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NicknameFieldNumber"></a> NicknameFieldNumber

```csharp
public const int NicknameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsSendmobileFieldNumber"></a> NotificationsSendmobileFieldNumber

```csharp
public const int NotificationsSendmobileFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsShowingameFieldNumber"></a> NotificationsShowingameFieldNumber

```csharp
public const int NotificationsShowingameFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsShowmessagesFieldNumber"></a> NotificationsShowmessagesFieldNumber

```csharp
public const int NotificationsShowmessagesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsShowonlineFieldNumber"></a> NotificationsShowonlineFieldNumber

```csharp
public const int NotificationsShowonlineFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_SoundsShowingameFieldNumber"></a> SoundsShowingameFieldNumber

```csharp
public const int SoundsShowingameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_SoundsShowmessagesFieldNumber"></a> SoundsShowmessagesFieldNumber

```csharp
public const int SoundsShowmessagesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_SoundsShowonlineFieldNumber"></a> SoundsShowonlineFieldNumber

```csharp
public const int SoundsShowonlineFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasNickname"></a> HasNickname

```csharp
public bool HasNickname { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasNotificationsSendmobile"></a> HasNotificationsSendmobile

```csharp
public bool HasNotificationsSendmobile { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasNotificationsShowingame"></a> HasNotificationsShowingame

```csharp
public bool HasNotificationsShowingame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasNotificationsShowmessages"></a> HasNotificationsShowmessages

```csharp
public bool HasNotificationsShowmessages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasNotificationsShowonline"></a> HasNotificationsShowonline

```csharp
public bool HasNotificationsShowonline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasSoundsShowingame"></a> HasSoundsShowingame

```csharp
public bool HasSoundsShowingame { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasSoundsShowmessages"></a> HasSoundsShowmessages

```csharp
public bool HasSoundsShowmessages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_HasSoundsShowonline"></a> HasSoundsShowonline

```csharp
public bool HasSoundsShowonline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Nickname"></a> Nickname

```csharp
public string Nickname { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsSendmobile"></a> NotificationsSendmobile

```csharp
public ENotificationSetting NotificationsSendmobile { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsShowingame"></a> NotificationsShowingame

```csharp
public ENotificationSetting NotificationsShowingame { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsShowmessages"></a> NotificationsShowmessages

```csharp
public ENotificationSetting NotificationsShowmessages { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_NotificationsShowonline"></a> NotificationsShowonline

```csharp
public ENotificationSetting NotificationsShowonline { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Parser"></a> Parser

```csharp
public static MessageParser<PerFriendPreferences> Parser { get; }
```

#### Property Value

 MessageParser<[PerFriendPreferences](Divine.Protobufs.Steam.PerFriendPreferences.md)\>

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_SoundsShowingame"></a> SoundsShowingame

```csharp
public ENotificationSetting SoundsShowingame { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_SoundsShowmessages"></a> SoundsShowmessages

```csharp
public ENotificationSetting SoundsShowmessages { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_SoundsShowonline"></a> SoundsShowonline

```csharp
public ENotificationSetting SoundsShowonline { get; set; }
```

#### Property Value

 [ENotificationSetting](Divine.Protobufs.Steam.ENotificationSetting.md)

## Methods

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearNickname"></a> ClearNickname\(\)

```csharp
public void ClearNickname()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearNotificationsSendmobile"></a> ClearNotificationsSendmobile\(\)

```csharp
public void ClearNotificationsSendmobile()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearNotificationsShowingame"></a> ClearNotificationsShowingame\(\)

```csharp
public void ClearNotificationsShowingame()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearNotificationsShowmessages"></a> ClearNotificationsShowmessages\(\)

```csharp
public void ClearNotificationsShowmessages()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearNotificationsShowonline"></a> ClearNotificationsShowonline\(\)

```csharp
public void ClearNotificationsShowonline()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearSoundsShowingame"></a> ClearSoundsShowingame\(\)

```csharp
public void ClearSoundsShowingame()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearSoundsShowmessages"></a> ClearSoundsShowmessages\(\)

```csharp
public void ClearSoundsShowmessages()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ClearSoundsShowonline"></a> ClearSoundsShowonline\(\)

```csharp
public void ClearSoundsShowonline()
```

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Clone"></a> Clone\(\)

```csharp
public PerFriendPreferences Clone()
```

#### Returns

 [PerFriendPreferences](Divine.Protobufs.Steam.PerFriendPreferences.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_Equals_Divine_Protobufs_Steam_PerFriendPreferences_"></a> Equals\(PerFriendPreferences\)

```csharp
public bool Equals(PerFriendPreferences other)
```

#### Parameters

`other` [PerFriendPreferences](Divine.Protobufs.Steam.PerFriendPreferences.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_MergeFrom_Divine_Protobufs_Steam_PerFriendPreferences_"></a> MergeFrom\(PerFriendPreferences\)

```csharp
public void MergeFrom(PerFriendPreferences other)
```

#### Parameters

`other` [PerFriendPreferences](Divine.Protobufs.Steam.PerFriendPreferences.md)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PerFriendPreferences_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

