# <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount"></a> Class CMsgGCToServerCheerData.Types.CheerTypeCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerCheerData.Types.CheerTypeCount : IMessage<CMsgGCToServerCheerData.Types.CheerTypeCount>, IEquatable<CMsgGCToServerCheerData.Types.CheerTypeCount>, IDeepCloneable<CMsgGCToServerCheerData.Types.CheerTypeCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerCheerData.Types.CheerTypeCount](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.CheerTypeCount.md)

#### Implements

IMessage<CMsgGCToServerCheerData.Types.CheerTypeCount\>, 
[IEquatable<CMsgGCToServerCheerData.Types.CheerTypeCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerCheerData.Types.CheerTypeCount\>, 
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
[EnumerableExtensions.In<CMsgGCToServerCheerData.Types.CheerTypeCount\>\(CMsgGCToServerCheerData.Types.CheerTypeCount, params CMsgGCToServerCheerData.Types.CheerTypeCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount__ctor"></a> CheerTypeCount\(\)

```csharp
public CheerTypeCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount__ctor_Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_"></a> CheerTypeCount\(CheerTypeCount\)

```csharp
public CheerTypeCount(CMsgGCToServerCheerData.Types.CheerTypeCount other)
```

#### Parameters

`other` [CMsgGCToServerCheerData](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.md).[CheerTypeCount](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.CheerTypeCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_CheerCountFieldNumber"></a> CheerCountFieldNumber

```csharp
public const int CheerCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_CheerTypeFieldNumber"></a> CheerTypeFieldNumber

```csharp
public const int CheerTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_CheerCount"></a> CheerCount

```csharp
public uint CheerCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_CheerType"></a> CheerType

```csharp
public uint CheerType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_HasCheerCount"></a> HasCheerCount

```csharp
public bool HasCheerCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_HasCheerType"></a> HasCheerType

```csharp
public bool HasCheerType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerCheerData.Types.CheerTypeCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerCheerData](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.md).[CheerTypeCount](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.CheerTypeCount.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_ClearCheerCount"></a> ClearCheerCount\(\)

```csharp
public void ClearCheerCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_ClearCheerType"></a> ClearCheerType\(\)

```csharp
public void ClearCheerType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerCheerData.Types.CheerTypeCount Clone()
```

#### Returns

 [CMsgGCToServerCheerData](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.md).[CheerTypeCount](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.CheerTypeCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_Equals_Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_"></a> Equals\(CheerTypeCount\)

```csharp
public bool Equals(CMsgGCToServerCheerData.Types.CheerTypeCount other)
```

#### Parameters

`other` [CMsgGCToServerCheerData](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.md).[CheerTypeCount](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.CheerTypeCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_"></a> MergeFrom\(CheerTypeCount\)

```csharp
public void MergeFrom(CMsgGCToServerCheerData.Types.CheerTypeCount other)
```

#### Parameters

`other` [CMsgGCToServerCheerData](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.md).[Types](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.md).[CheerTypeCount](Divine.Protobufs.Dota2.CMsgGCToServerCheerData.Types.CheerTypeCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerCheerData_Types_CheerTypeCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

