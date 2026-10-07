# <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll"></a> Class CMsgClientToGCUnderDraftReroll

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCUnderDraftReroll : IMessage<CMsgClientToGCUnderDraftReroll>, IEquatable<CMsgClientToGCUnderDraftReroll>, IDeepCloneable<CMsgClientToGCUnderDraftReroll>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCUnderDraftReroll](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftReroll.md)

#### Implements

IMessage<CMsgClientToGCUnderDraftReroll\>, 
[IEquatable<CMsgClientToGCUnderDraftReroll\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCUnderDraftReroll\>, 
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
[EnumerableExtensions.In<CMsgClientToGCUnderDraftReroll\>\(CMsgClientToGCUnderDraftReroll, params CMsgClientToGCUnderDraftReroll\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll__ctor"></a> CMsgClientToGCUnderDraftReroll\(\)

```csharp
public CMsgClientToGCUnderDraftReroll()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll__ctor_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_"></a> CMsgClientToGCUnderDraftReroll\(CMsgClientToGCUnderDraftReroll\)

```csharp
public CMsgClientToGCUnderDraftReroll(CMsgClientToGCUnderDraftReroll other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftReroll](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftReroll.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCUnderDraftReroll> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCUnderDraftReroll](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftReroll.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCUnderDraftReroll Clone()
```

#### Returns

 [CMsgClientToGCUnderDraftReroll](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftReroll.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_Equals_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_"></a> Equals\(CMsgClientToGCUnderDraftReroll\)

```csharp
public bool Equals(CMsgClientToGCUnderDraftReroll other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftReroll](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftReroll.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_"></a> MergeFrom\(CMsgClientToGCUnderDraftReroll\)

```csharp
public void MergeFrom(CMsgClientToGCUnderDraftReroll other)
```

#### Parameters

`other` [CMsgClientToGCUnderDraftReroll](Divine.Protobufs.Dota2.CMsgClientToGCUnderDraftReroll.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCUnderDraftReroll_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

