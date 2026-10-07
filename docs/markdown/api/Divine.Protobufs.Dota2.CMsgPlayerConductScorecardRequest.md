# <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest"></a> Class CMsgPlayerConductScorecardRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerConductScorecardRequest : IMessage<CMsgPlayerConductScorecardRequest>, IEquatable<CMsgPlayerConductScorecardRequest>, IDeepCloneable<CMsgPlayerConductScorecardRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerConductScorecardRequest](Divine.Protobufs.Dota2.CMsgPlayerConductScorecardRequest.md)

#### Implements

IMessage<CMsgPlayerConductScorecardRequest\>, 
[IEquatable<CMsgPlayerConductScorecardRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerConductScorecardRequest\>, 
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
[EnumerableExtensions.In<CMsgPlayerConductScorecardRequest\>\(CMsgPlayerConductScorecardRequest, params CMsgPlayerConductScorecardRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest__ctor"></a> CMsgPlayerConductScorecardRequest\(\)

```csharp
public CMsgPlayerConductScorecardRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest__ctor_Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_"></a> CMsgPlayerConductScorecardRequest\(CMsgPlayerConductScorecardRequest\)

```csharp
public CMsgPlayerConductScorecardRequest(CMsgPlayerConductScorecardRequest other)
```

#### Parameters

`other` [CMsgPlayerConductScorecardRequest](Divine.Protobufs.Dota2.CMsgPlayerConductScorecardRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerConductScorecardRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerConductScorecardRequest](Divine.Protobufs.Dota2.CMsgPlayerConductScorecardRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerConductScorecardRequest Clone()
```

#### Returns

 [CMsgPlayerConductScorecardRequest](Divine.Protobufs.Dota2.CMsgPlayerConductScorecardRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_Equals_Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_"></a> Equals\(CMsgPlayerConductScorecardRequest\)

```csharp
public bool Equals(CMsgPlayerConductScorecardRequest other)
```

#### Parameters

`other` [CMsgPlayerConductScorecardRequest](Divine.Protobufs.Dota2.CMsgPlayerConductScorecardRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_"></a> MergeFrom\(CMsgPlayerConductScorecardRequest\)

```csharp
public void MergeFrom(CMsgPlayerConductScorecardRequest other)
```

#### Parameters

`other` [CMsgPlayerConductScorecardRequest](Divine.Protobufs.Dota2.CMsgPlayerConductScorecardRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerConductScorecardRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

