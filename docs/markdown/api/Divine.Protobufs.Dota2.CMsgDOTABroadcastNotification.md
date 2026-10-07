# <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification"></a> Class CMsgDOTABroadcastNotification

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTABroadcastNotification : IMessage<CMsgDOTABroadcastNotification>, IEquatable<CMsgDOTABroadcastNotification>, IDeepCloneable<CMsgDOTABroadcastNotification>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTABroadcastNotification](Divine.Protobufs.Dota2.CMsgDOTABroadcastNotification.md)

#### Implements

IMessage<CMsgDOTABroadcastNotification\>, 
[IEquatable<CMsgDOTABroadcastNotification\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTABroadcastNotification\>, 
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
[EnumerableExtensions.In<CMsgDOTABroadcastNotification\>\(CMsgDOTABroadcastNotification, params CMsgDOTABroadcastNotification\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification__ctor"></a> CMsgDOTABroadcastNotification\(\)

```csharp
public CMsgDOTABroadcastNotification()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification__ctor_Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_"></a> CMsgDOTABroadcastNotification\(CMsgDOTABroadcastNotification\)

```csharp
public CMsgDOTABroadcastNotification(CMsgDOTABroadcastNotification other)
```

#### Parameters

`other` [CMsgDOTABroadcastNotification](Divine.Protobufs.Dota2.CMsgDOTABroadcastNotification.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTABroadcastNotification> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTABroadcastNotification](Divine.Protobufs.Dota2.CMsgDOTABroadcastNotification.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_Clone"></a> Clone\(\)

```csharp
public CMsgDOTABroadcastNotification Clone()
```

#### Returns

 [CMsgDOTABroadcastNotification](Divine.Protobufs.Dota2.CMsgDOTABroadcastNotification.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_Equals_Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_"></a> Equals\(CMsgDOTABroadcastNotification\)

```csharp
public bool Equals(CMsgDOTABroadcastNotification other)
```

#### Parameters

`other` [CMsgDOTABroadcastNotification](Divine.Protobufs.Dota2.CMsgDOTABroadcastNotification.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_"></a> MergeFrom\(CMsgDOTABroadcastNotification\)

```csharp
public void MergeFrom(CMsgDOTABroadcastNotification other)
```

#### Parameters

`other` [CMsgDOTABroadcastNotification](Divine.Protobufs.Dota2.CMsgDOTABroadcastNotification.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTABroadcastNotification_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

