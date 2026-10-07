# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults"></a> Class CMsgDOTADPCTeamResults

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCTeamResults : IMessage<CMsgDOTADPCTeamResults>, IEquatable<CMsgDOTADPCTeamResults>, IDeepCloneable<CMsgDOTADPCTeamResults>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md)

#### Implements

IMessage<CMsgDOTADPCTeamResults\>, 
[IEquatable<CMsgDOTADPCTeamResults\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCTeamResults\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCTeamResults\>\(CMsgDOTADPCTeamResults, params CMsgDOTADPCTeamResults\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults__ctor"></a> CMsgDOTADPCTeamResults\(\)

```csharp
public CMsgDOTADPCTeamResults()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_"></a> CMsgDOTADPCTeamResults\(CMsgDOTADPCTeamResults\)

```csharp
public CMsgDOTADPCTeamResults(CMsgDOTADPCTeamResults other)
```

#### Parameters

`other` [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCTeamResults> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Results"></a> Results

```csharp
public RepeatedField<CMsgDOTADPCTeamResults.Types.Result> Results { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.Types.Result.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCTeamResults Clone()
```

#### Returns

 [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_"></a> Equals\(CMsgDOTADPCTeamResults\)

```csharp
public bool Equals(CMsgDOTADPCTeamResults other)
```

#### Parameters

`other` [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_"></a> MergeFrom\(CMsgDOTADPCTeamResults\)

```csharp
public void MergeFrom(CMsgDOTADPCTeamResults other)
```

#### Parameters

`other` [CMsgDOTADPCTeamResults](Divine.Protobufs.Dota2.CMsgDOTADPCTeamResults.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCTeamResults_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

