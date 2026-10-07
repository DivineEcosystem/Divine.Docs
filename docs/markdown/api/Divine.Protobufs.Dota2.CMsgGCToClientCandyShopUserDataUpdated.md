# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated"></a> Class CMsgGCToClientCandyShopUserDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCandyShopUserDataUpdated : IMessage<CMsgGCToClientCandyShopUserDataUpdated>, IEquatable<CMsgGCToClientCandyShopUserDataUpdated>, IDeepCloneable<CMsgGCToClientCandyShopUserDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCandyShopUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCandyShopUserDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientCandyShopUserDataUpdated\>, 
[IEquatable<CMsgGCToClientCandyShopUserDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCandyShopUserDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCandyShopUserDataUpdated\>\(CMsgGCToClientCandyShopUserDataUpdated, params CMsgGCToClientCandyShopUserDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated__ctor"></a> CMsgGCToClientCandyShopUserDataUpdated\(\)

```csharp
public CMsgGCToClientCandyShopUserDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_"></a> CMsgGCToClientCandyShopUserDataUpdated\(CMsgGCToClientCandyShopUserDataUpdated\)

```csharp
public CMsgGCToClientCandyShopUserDataUpdated(CMsgGCToClientCandyShopUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCandyShopUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCandyShopUserDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_CandyShopIdFieldNumber"></a> CandyShopIdFieldNumber

```csharp
public const int CandyShopIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_CandyShopId"></a> CandyShopId

```csharp
public uint CandyShopId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_HasCandyShopId"></a> HasCandyShopId

```csharp
public bool HasCandyShopId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCandyShopUserDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCandyShopUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCandyShopUserDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_UserData"></a> UserData

```csharp
public CMsgCandyShopUserData UserData { get; set; }
```

#### Property Value

 [CMsgCandyShopUserData](Divine.Protobufs.Dota2.CMsgCandyShopUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_ClearCandyShopId"></a> ClearCandyShopId\(\)

```csharp
public void ClearCandyShopId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCandyShopUserDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientCandyShopUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCandyShopUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_"></a> Equals\(CMsgGCToClientCandyShopUserDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientCandyShopUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCandyShopUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCandyShopUserDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_"></a> MergeFrom\(CMsgGCToClientCandyShopUserDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientCandyShopUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCandyShopUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCandyShopUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCandyShopUserDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

