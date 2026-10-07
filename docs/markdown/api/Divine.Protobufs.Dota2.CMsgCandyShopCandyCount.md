# <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount"></a> Class CMsgCandyShopCandyCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgCandyShopCandyCount : IMessage<CMsgCandyShopCandyCount>, IEquatable<CMsgCandyShopCandyCount>, IDeepCloneable<CMsgCandyShopCandyCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)

#### Implements

IMessage<CMsgCandyShopCandyCount\>, 
[IEquatable<CMsgCandyShopCandyCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgCandyShopCandyCount\>, 
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
[EnumerableExtensions.In<CMsgCandyShopCandyCount\>\(CMsgCandyShopCandyCount, params CMsgCandyShopCandyCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount__ctor"></a> CMsgCandyShopCandyCount\(\)

```csharp
public CMsgCandyShopCandyCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount__ctor_Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_"></a> CMsgCandyShopCandyCount\(CMsgCandyShopCandyCount\)

```csharp
public CMsgCandyShopCandyCount(CMsgCandyShopCandyCount other)
```

#### Parameters

`other` [CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_CandyCountFieldNumber"></a> CandyCountFieldNumber

```csharp
public const int CandyCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_CandyTypeFieldNumber"></a> CandyTypeFieldNumber

```csharp
public const int CandyTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_CandyCount"></a> CandyCount

```csharp
public uint CandyCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_CandyType"></a> CandyType

```csharp
public uint CandyType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_HasCandyCount"></a> HasCandyCount

```csharp
public bool HasCandyCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_HasCandyType"></a> HasCandyType

```csharp
public bool HasCandyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgCandyShopCandyCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_ClearCandyCount"></a> ClearCandyCount\(\)

```csharp
public void ClearCandyCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_ClearCandyType"></a> ClearCandyType\(\)

```csharp
public void ClearCandyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_Clone"></a> Clone\(\)

```csharp
public CMsgCandyShopCandyCount Clone()
```

#### Returns

 [CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_Equals_Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_"></a> Equals\(CMsgCandyShopCandyCount\)

```csharp
public bool Equals(CMsgCandyShopCandyCount other)
```

#### Parameters

`other` [CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_MergeFrom_Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_"></a> MergeFrom\(CMsgCandyShopCandyCount\)

```csharp
public void MergeFrom(CMsgCandyShopCandyCount other)
```

#### Parameters

`other` [CMsgCandyShopCandyCount](Divine.Protobufs.Dota2.CMsgCandyShopCandyCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgCandyShopCandyCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

