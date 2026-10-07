# <a id="Divine_Protobufs_Dota2_CMsgCraftStatue"></a> Class CMsgCraftStatue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCraftStatue : IMessage<CMsgCraftStatue>, IEquatable<CMsgCraftStatue>, IDeepCloneable<CMsgCraftStatue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCraftStatue](Divine.Protobufs.Dota2.CMsgCraftStatue.md)

#### Implements

IMessage<CMsgCraftStatue\>, 
[IEquatable<CMsgCraftStatue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCraftStatue\>, 
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
[EnumerableExtensions.In<CMsgCraftStatue\>\(CMsgCraftStatue, params CMsgCraftStatue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue__ctor"></a> CMsgCraftStatue\(\)

```csharp
public CMsgCraftStatue()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue__ctor_Divine_Protobufs_Dota2_CMsgCraftStatue_"></a> CMsgCraftStatue\(CMsgCraftStatue\)

```csharp
public CMsgCraftStatue(CMsgCraftStatue other)
```

#### Parameters

`other` [CMsgCraftStatue](Divine.Protobufs.Dota2.CMsgCraftStatue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_CycleFieldNumber"></a> CycleFieldNumber

```csharp
public const int CycleFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HeroidFieldNumber"></a> HeroidFieldNumber

```csharp
public const int HeroidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_PedestalItemdefFieldNumber"></a> PedestalItemdefFieldNumber

```csharp
public const int PedestalItemdefFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_SequencenameFieldNumber"></a> SequencenameFieldNumber

```csharp
public const int SequencenameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ToolidFieldNumber"></a> ToolidFieldNumber

```csharp
public const int ToolidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Cycle"></a> Cycle

```csharp
public float Cycle { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HasCycle"></a> HasCycle

```csharp
public bool HasCycle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HasHeroid"></a> HasHeroid

```csharp
public bool HasHeroid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HasPedestalItemdef"></a> HasPedestalItemdef

```csharp
public bool HasPedestalItemdef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HasSequencename"></a> HasSequencename

```csharp
public bool HasSequencename { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_HasToolid"></a> HasToolid

```csharp
public bool HasToolid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Heroid"></a> Heroid

```csharp
public uint Heroid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCraftStatue> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCraftStatue](Divine.Protobufs.Dota2.CMsgCraftStatue.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_PedestalItemdef"></a> PedestalItemdef

```csharp
public uint PedestalItemdef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Sequencename"></a> Sequencename

```csharp
public string Sequencename { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Toolid"></a> Toolid

```csharp
public ulong Toolid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ClearCycle"></a> ClearCycle\(\)

```csharp
public void ClearCycle()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ClearHeroid"></a> ClearHeroid\(\)

```csharp
public void ClearHeroid()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ClearPedestalItemdef"></a> ClearPedestalItemdef\(\)

```csharp
public void ClearPedestalItemdef()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ClearSequencename"></a> ClearSequencename\(\)

```csharp
public void ClearSequencename()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ClearToolid"></a> ClearToolid\(\)

```csharp
public void ClearToolid()
```

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Clone"></a> Clone\(\)

```csharp
public CMsgCraftStatue Clone()
```

#### Returns

 [CMsgCraftStatue](Divine.Protobufs.Dota2.CMsgCraftStatue.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_Equals_Divine_Protobufs_Dota2_CMsgCraftStatue_"></a> Equals\(CMsgCraftStatue\)

```csharp
public bool Equals(CMsgCraftStatue other)
```

#### Parameters

`other` [CMsgCraftStatue](Divine.Protobufs.Dota2.CMsgCraftStatue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_MergeFrom_Divine_Protobufs_Dota2_CMsgCraftStatue_"></a> MergeFrom\(CMsgCraftStatue\)

```csharp
public void MergeFrom(CMsgCraftStatue other)
```

#### Parameters

`other` [CMsgCraftStatue](Divine.Protobufs.Dota2.CMsgCraftStatue.md)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCraftStatue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

