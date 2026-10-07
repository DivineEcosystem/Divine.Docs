# <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification"></a> Class CMsgGCNotifications\_Notification

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCNotifications_Notification : IMessage<CMsgGCNotifications_Notification>, IEquatable<CMsgGCNotifications_Notification>, IDeepCloneable<CMsgGCNotifications_Notification>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)

#### Implements

IMessage<CMsgGCNotifications\_Notification\>, 
[IEquatable<CMsgGCNotifications\_Notification\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCNotifications\_Notification\>, 
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
[EnumerableExtensions.In<CMsgGCNotifications\_Notification\>\(CMsgGCNotifications\_Notification, params CMsgGCNotifications\_Notification\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification__ctor"></a> CMsgGCNotifications\_Notification\(\)

```csharp
public CMsgGCNotifications_Notification()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification__ctor_Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_"></a> CMsgGCNotifications\_Notification\(CMsgGCNotifications\_Notification\)

```csharp
public CMsgGCNotifications_Notification(CMsgGCNotifications_Notification other)
```

#### Parameters

`other` [CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ReferenceAFieldNumber"></a> ReferenceAFieldNumber

```csharp
public const int ReferenceAFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ReferenceBFieldNumber"></a> ReferenceBFieldNumber

```csharp
public const int ReferenceBFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ReferenceCFieldNumber"></a> ReferenceCFieldNumber

```csharp
public const int ReferenceCFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_UnreadFieldNumber"></a> UnreadFieldNumber

```csharp
public const int UnreadFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasReferenceA"></a> HasReferenceA

```csharp
public bool HasReferenceA { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasReferenceB"></a> HasReferenceB

```csharp
public bool HasReferenceB { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasReferenceC"></a> HasReferenceC

```csharp
public bool HasReferenceC { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasTimestamp"></a> HasTimestamp

```csharp
public bool HasTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_HasUnread"></a> HasUnread

```csharp
public bool HasUnread { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCNotifications_Notification> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ReferenceA"></a> ReferenceA

```csharp
public uint ReferenceA { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ReferenceB"></a> ReferenceB

```csharp
public uint ReferenceB { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ReferenceC"></a> ReferenceC

```csharp
public uint ReferenceC { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Timestamp"></a> Timestamp

```csharp
public uint Timestamp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Unread"></a> Unread

```csharp
public bool Unread { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearReferenceA"></a> ClearReferenceA\(\)

```csharp
public void ClearReferenceA()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearReferenceB"></a> ClearReferenceB\(\)

```csharp
public void ClearReferenceB()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearReferenceC"></a> ClearReferenceC\(\)

```csharp
public void ClearReferenceC()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearTimestamp"></a> ClearTimestamp\(\)

```csharp
public void ClearTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ClearUnread"></a> ClearUnread\(\)

```csharp
public void ClearUnread()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Clone"></a> Clone\(\)

```csharp
public CMsgGCNotifications_Notification Clone()
```

#### Returns

 [CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_Equals_Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_"></a> Equals\(CMsgGCNotifications\_Notification\)

```csharp
public bool Equals(CMsgGCNotifications_Notification other)
```

#### Parameters

`other` [CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_MergeFrom_Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_"></a> MergeFrom\(CMsgGCNotifications\_Notification\)

```csharp
public void MergeFrom(CMsgGCNotifications_Notification other)
```

#### Parameters

`other` [CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotifications_Notification_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

