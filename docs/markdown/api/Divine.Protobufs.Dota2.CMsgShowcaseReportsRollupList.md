# <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList"></a> Class CMsgShowcaseReportsRollupList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseReportsRollupList : IMessage<CMsgShowcaseReportsRollupList>, IEquatable<CMsgShowcaseReportsRollupList>, IDeepCloneable<CMsgShowcaseReportsRollupList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseReportsRollupList](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupList.md)

#### Implements

IMessage<CMsgShowcaseReportsRollupList\>, 
[IEquatable<CMsgShowcaseReportsRollupList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseReportsRollupList\>, 
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
[EnumerableExtensions.In<CMsgShowcaseReportsRollupList\>\(CMsgShowcaseReportsRollupList, params CMsgShowcaseReportsRollupList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList__ctor"></a> CMsgShowcaseReportsRollupList\(\)

```csharp
public CMsgShowcaseReportsRollupList()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList__ctor_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_"></a> CMsgShowcaseReportsRollupList\(CMsgShowcaseReportsRollupList\)

```csharp
public CMsgShowcaseReportsRollupList(CMsgShowcaseReportsRollupList other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupList](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_RollupsFieldNumber"></a> RollupsFieldNumber

```csharp
public const int RollupsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseReportsRollupList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseReportsRollupList](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupList.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_Rollups"></a> Rollups

```csharp
public RepeatedField<CMsgShowcaseReportsRollupInfo> Rollups { get; }
```

#### Property Value

 RepeatedField<[CMsgShowcaseReportsRollupInfo](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseReportsRollupList Clone()
```

#### Returns

 [CMsgShowcaseReportsRollupList](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupList.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_Equals_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_"></a> Equals\(CMsgShowcaseReportsRollupList\)

```csharp
public bool Equals(CMsgShowcaseReportsRollupList other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupList](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_"></a> MergeFrom\(CMsgShowcaseReportsRollupList\)

```csharp
public void MergeFrom(CMsgShowcaseReportsRollupList other)
```

#### Parameters

`other` [CMsgShowcaseReportsRollupList](Divine.Protobufs.Dota2.CMsgShowcaseReportsRollupList.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseReportsRollupList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

