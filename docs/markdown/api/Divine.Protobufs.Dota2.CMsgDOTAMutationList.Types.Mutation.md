# <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation"></a> Class CMsgDOTAMutationList.Types.Mutation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMutationList.Types.Mutation : IMessage<CMsgDOTAMutationList.Types.Mutation>, IEquatable<CMsgDOTAMutationList.Types.Mutation>, IDeepCloneable<CMsgDOTAMutationList.Types.Mutation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMutationList.Types.Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)

#### Implements

IMessage<CMsgDOTAMutationList.Types.Mutation\>, 
[IEquatable<CMsgDOTAMutationList.Types.Mutation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMutationList.Types.Mutation\>, 
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
[EnumerableExtensions.In<CMsgDOTAMutationList.Types.Mutation\>\(CMsgDOTAMutationList.Types.Mutation, params CMsgDOTAMutationList.Types.Mutation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation__ctor"></a> Mutation\(\)

```csharp
public Mutation()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation__ctor_Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_"></a> Mutation\(Mutation\)

```csharp
public Mutation(CMsgDOTAMutationList.Types.Mutation other)
```

#### Parameters

`other` [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.md).[Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_DescriptionFieldNumber"></a> DescriptionFieldNumber

```csharp
public const int DescriptionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Description"></a> Description

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_HasDescription"></a> HasDescription

```csharp
public bool HasDescription { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMutationList.Types.Mutation> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.md).[Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_ClearDescription"></a> ClearDescription\(\)

```csharp
public void ClearDescription()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMutationList.Types.Mutation Clone()
```

#### Returns

 [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.md).[Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_Equals_Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_"></a> Equals\(Mutation\)

```csharp
public bool Equals(CMsgDOTAMutationList.Types.Mutation other)
```

#### Parameters

`other` [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.md).[Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_"></a> MergeFrom\(Mutation\)

```csharp
public void MergeFrom(CMsgDOTAMutationList.Types.Mutation other)
```

#### Parameters

`other` [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.md).[Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Types_Mutation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

