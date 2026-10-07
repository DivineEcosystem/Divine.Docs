# <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData"></a> Class CMsgClientToGCCraftworksGetUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCCraftworksGetUserData : IMessage<CMsgClientToGCCraftworksGetUserData>, IEquatable<CMsgClientToGCCraftworksGetUserData>, IDeepCloneable<CMsgClientToGCCraftworksGetUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCCraftworksGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserData.md)

#### Implements

IMessage<CMsgClientToGCCraftworksGetUserData\>, 
[IEquatable<CMsgClientToGCCraftworksGetUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCCraftworksGetUserData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCCraftworksGetUserData\>\(CMsgClientToGCCraftworksGetUserData, params CMsgClientToGCCraftworksGetUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData__ctor"></a> CMsgClientToGCCraftworksGetUserData\(\)

```csharp
public CMsgClientToGCCraftworksGetUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_"></a> CMsgClientToGCCraftworksGetUserData\(CMsgClientToGCCraftworksGetUserData\)

```csharp
public CMsgClientToGCCraftworksGetUserData(CMsgClientToGCCraftworksGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_CraftworksIdFieldNumber"></a> CraftworksIdFieldNumber

```csharp
public const int CraftworksIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_CraftworksId"></a> CraftworksId

```csharp
public uint CraftworksId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_HasCraftworksId"></a> HasCraftworksId

```csharp
public bool HasCraftworksId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCCraftworksGetUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCCraftworksGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_ClearCraftworksId"></a> ClearCraftworksId\(\)

```csharp
public void ClearCraftworksId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCCraftworksGetUserData Clone()
```

#### Returns

 [CMsgClientToGCCraftworksGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_"></a> Equals\(CMsgClientToGCCraftworksGetUserData\)

```csharp
public bool Equals(CMsgClientToGCCraftworksGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_"></a> MergeFrom\(CMsgClientToGCCraftworksGetUserData\)

```csharp
public void MergeFrom(CMsgClientToGCCraftworksGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCCraftworksGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCCraftworksGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCCraftworksGetUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

