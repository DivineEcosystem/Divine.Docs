# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData"></a> Class CMsgClientToGCCandyShopGetUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCandyShopGetUserData : IMessage<CMsgClientToGCCandyShopGetUserData>, IEquatable<CMsgClientToGCCandyShopGetUserData>, IDeepCloneable<CMsgClientToGCCandyShopGetUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCandyShopGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserData.md)

#### Implements

IMessage<CMsgClientToGCCandyShopGetUserData\>, 
[IEquatable<CMsgClientToGCCandyShopGetUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCandyShopGetUserData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCandyShopGetUserData\>\(CMsgClientToGCCandyShopGetUserData, params CMsgClientToGCCandyShopGetUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData__ctor"></a> CMsgClientToGCCandyShopGetUserData\(\)

```csharp
public CMsgClientToGCCandyShopGetUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_"></a> CMsgClientToGCCandyShopGetUserData\(CMsgClientToGCCandyShopGetUserData\)

```csharp
public CMsgClientToGCCandyShopGetUserData(CMsgClientToGCCandyShopGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCandyShopGetUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCandyShopGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCandyShopGetUserData Clone()
```

#### Returns

 [CMsgClientToGCCandyShopGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_"></a> Equals\(CMsgClientToGCCandyShopGetUserData\)

```csharp
public bool Equals(CMsgClientToGCCandyShopGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_"></a> MergeFrom\(CMsgClientToGCCandyShopGetUserData\)

```csharp
public void MergeFrom(CMsgClientToGCCandyShopGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCCandyShopGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCandyShopGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCandyShopGetUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

