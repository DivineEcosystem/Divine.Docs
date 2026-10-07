# <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate"></a> Class CMsgGCNotificationsUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCNotificationsUpdate : IMessage<CMsgGCNotificationsUpdate>, IEquatable<CMsgGCNotificationsUpdate>, IDeepCloneable<CMsgGCNotificationsUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)

#### Implements

IMessage<CMsgGCNotificationsUpdate\>, 
[IEquatable<CMsgGCNotificationsUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCNotificationsUpdate\>, 
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
[EnumerableExtensions.In<CMsgGCNotificationsUpdate\>\(CMsgGCNotificationsUpdate, params CMsgGCNotificationsUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate__ctor"></a> CMsgGCNotificationsUpdate\(\)

```csharp
public CMsgGCNotificationsUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate__ctor_Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_"></a> CMsgGCNotificationsUpdate\(CMsgGCNotificationsUpdate\)

```csharp
public CMsgGCNotificationsUpdate(CMsgGCNotificationsUpdate other)
```

#### Parameters

`other` [CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_NotificationsFieldNumber"></a> NotificationsFieldNumber

```csharp
public const int NotificationsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Notifications"></a> Notifications

```csharp
public RepeatedField<CMsgGCNotifications_Notification> Notifications { get; }
```

#### Property Value

 RepeatedField<[CMsgGCNotifications\_Notification](Divine.Protobufs.Dota2.CMsgGCNotifications\_Notification.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCNotificationsUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Result"></a> Result

```csharp
public CMsgGCNotificationsUpdate.Types.EResult Result { get; set; }
```

#### Property Value

 [CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md).[Types](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.Types.EResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgGCNotificationsUpdate Clone()
```

#### Returns

 [CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_Equals_Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_"></a> Equals\(CMsgGCNotificationsUpdate\)

```csharp
public bool Equals(CMsgGCNotificationsUpdate other)
```

#### Parameters

`other` [CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_"></a> MergeFrom\(CMsgGCNotificationsUpdate\)

```csharp
public void MergeFrom(CMsgGCNotificationsUpdate other)
```

#### Parameters

`other` [CMsgGCNotificationsUpdate](Divine.Protobufs.Dota2.CMsgGCNotificationsUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCNotificationsUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

