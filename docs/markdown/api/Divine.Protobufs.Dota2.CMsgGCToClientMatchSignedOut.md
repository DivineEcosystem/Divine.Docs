# <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut"></a> Class CMsgGCToClientMatchSignedOut

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientMatchSignedOut : IMessage<CMsgGCToClientMatchSignedOut>, IEquatable<CMsgGCToClientMatchSignedOut>, IDeepCloneable<CMsgGCToClientMatchSignedOut>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientMatchSignedOut](Divine.Protobufs.Dota2.CMsgGCToClientMatchSignedOut.md)

#### Implements

IMessage<CMsgGCToClientMatchSignedOut\>, 
[IEquatable<CMsgGCToClientMatchSignedOut\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientMatchSignedOut\>, 
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
[EnumerableExtensions.In<CMsgGCToClientMatchSignedOut\>\(CMsgGCToClientMatchSignedOut, params CMsgGCToClientMatchSignedOut\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut__ctor"></a> CMsgGCToClientMatchSignedOut\(\)

```csharp
public CMsgGCToClientMatchSignedOut()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut__ctor_Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_"></a> CMsgGCToClientMatchSignedOut\(CMsgGCToClientMatchSignedOut\)

```csharp
public CMsgGCToClientMatchSignedOut(CMsgGCToClientMatchSignedOut other)
```

#### Parameters

`other` [CMsgGCToClientMatchSignedOut](Divine.Protobufs.Dota2.CMsgGCToClientMatchSignedOut.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientMatchSignedOut> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientMatchSignedOut](Divine.Protobufs.Dota2.CMsgGCToClientMatchSignedOut.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientMatchSignedOut Clone()
```

#### Returns

 [CMsgGCToClientMatchSignedOut](Divine.Protobufs.Dota2.CMsgGCToClientMatchSignedOut.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_Equals_Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_"></a> Equals\(CMsgGCToClientMatchSignedOut\)

```csharp
public bool Equals(CMsgGCToClientMatchSignedOut other)
```

#### Parameters

`other` [CMsgGCToClientMatchSignedOut](Divine.Protobufs.Dota2.CMsgGCToClientMatchSignedOut.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_"></a> MergeFrom\(CMsgGCToClientMatchSignedOut\)

```csharp
public void MergeFrom(CMsgGCToClientMatchSignedOut other)
```

#### Parameters

`other` [CMsgGCToClientMatchSignedOut](Divine.Protobufs.Dota2.CMsgGCToClientMatchSignedOut.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMatchSignedOut_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

