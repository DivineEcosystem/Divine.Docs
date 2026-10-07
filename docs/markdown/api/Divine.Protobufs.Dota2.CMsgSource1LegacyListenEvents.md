# <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents"></a> Class CMsgSource1LegacyListenEvents

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSource1LegacyListenEvents : IMessage<CMsgSource1LegacyListenEvents>, IEquatable<CMsgSource1LegacyListenEvents>, IDeepCloneable<CMsgSource1LegacyListenEvents>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSource1LegacyListenEvents](Divine.Protobufs.Dota2.CMsgSource1LegacyListenEvents.md)

#### Implements

IMessage<CMsgSource1LegacyListenEvents\>, 
[IEquatable<CMsgSource1LegacyListenEvents\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSource1LegacyListenEvents\>, 
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
[EnumerableExtensions.In<CMsgSource1LegacyListenEvents\>\(CMsgSource1LegacyListenEvents, params CMsgSource1LegacyListenEvents\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents__ctor"></a> CMsgSource1LegacyListenEvents\(\)

```csharp
public CMsgSource1LegacyListenEvents()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents__ctor_Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_"></a> CMsgSource1LegacyListenEvents\(CMsgSource1LegacyListenEvents\)

```csharp
public CMsgSource1LegacyListenEvents(CMsgSource1LegacyListenEvents other)
```

#### Parameters

`other` [CMsgSource1LegacyListenEvents](Divine.Protobufs.Dota2.CMsgSource1LegacyListenEvents.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_EventarraybitsFieldNumber"></a> EventarraybitsFieldNumber

```csharp
public const int EventarraybitsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_PlayerslotFieldNumber"></a> PlayerslotFieldNumber

```csharp
public const int PlayerslotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Eventarraybits"></a> Eventarraybits

```csharp
public RepeatedField<uint> Eventarraybits { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_HasPlayerslot"></a> HasPlayerslot

```csharp
public bool HasPlayerslot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSource1LegacyListenEvents> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSource1LegacyListenEvents](Divine.Protobufs.Dota2.CMsgSource1LegacyListenEvents.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Playerslot"></a> Playerslot

```csharp
public int Playerslot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_ClearPlayerslot"></a> ClearPlayerslot\(\)

```csharp
public void ClearPlayerslot()
```

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Clone"></a> Clone\(\)

```csharp
public CMsgSource1LegacyListenEvents Clone()
```

#### Returns

 [CMsgSource1LegacyListenEvents](Divine.Protobufs.Dota2.CMsgSource1LegacyListenEvents.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_Equals_Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_"></a> Equals\(CMsgSource1LegacyListenEvents\)

```csharp
public bool Equals(CMsgSource1LegacyListenEvents other)
```

#### Parameters

`other` [CMsgSource1LegacyListenEvents](Divine.Protobufs.Dota2.CMsgSource1LegacyListenEvents.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_MergeFrom_Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_"></a> MergeFrom\(CMsgSource1LegacyListenEvents\)

```csharp
public void MergeFrom(CMsgSource1LegacyListenEvents other)
```

#### Parameters

`other` [CMsgSource1LegacyListenEvents](Divine.Protobufs.Dota2.CMsgSource1LegacyListenEvents.md)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSource1LegacyListenEvents_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

