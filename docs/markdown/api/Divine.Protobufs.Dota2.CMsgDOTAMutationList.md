# <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList"></a> Class CMsgDOTAMutationList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMutationList : IMessage<CMsgDOTAMutationList>, IEquatable<CMsgDOTAMutationList>, IDeepCloneable<CMsgDOTAMutationList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md)

#### Implements

IMessage<CMsgDOTAMutationList\>, 
[IEquatable<CMsgDOTAMutationList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMutationList\>, 
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
[EnumerableExtensions.In<CMsgDOTAMutationList\>\(CMsgDOTAMutationList, params CMsgDOTAMutationList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList__ctor"></a> CMsgDOTAMutationList\(\)

```csharp
public CMsgDOTAMutationList()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList__ctor_Divine_Protobufs_Dota2_CMsgDOTAMutationList_"></a> CMsgDOTAMutationList\(CMsgDOTAMutationList\)

```csharp
public CMsgDOTAMutationList(CMsgDOTAMutationList other)
```

#### Parameters

`other` [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_MutationsFieldNumber"></a> MutationsFieldNumber

```csharp
public const int MutationsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Mutations"></a> Mutations

```csharp
public RepeatedField<CMsgDOTAMutationList.Types.Mutation> Mutations { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.md).[Mutation](Divine.Protobufs.Dota2.CMsgDOTAMutationList.Types.Mutation.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMutationList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMutationList Clone()
```

#### Returns

 [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_Equals_Divine_Protobufs_Dota2_CMsgDOTAMutationList_"></a> Equals\(CMsgDOTAMutationList\)

```csharp
public bool Equals(CMsgDOTAMutationList other)
```

#### Parameters

`other` [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMutationList_"></a> MergeFrom\(CMsgDOTAMutationList\)

```csharp
public void MergeFrom(CMsgDOTAMutationList other)
```

#### Parameters

`other` [CMsgDOTAMutationList](Divine.Protobufs.Dota2.CMsgDOTAMutationList.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMutationList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

