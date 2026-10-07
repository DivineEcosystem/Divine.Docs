# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated"></a> Class CMsgGCToClientCraftworksUserDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCraftworksUserDataUpdated : IMessage<CMsgGCToClientCraftworksUserDataUpdated>, IEquatable<CMsgGCToClientCraftworksUserDataUpdated>, IDeepCloneable<CMsgGCToClientCraftworksUserDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCraftworksUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCraftworksUserDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientCraftworksUserDataUpdated\>, 
[IEquatable<CMsgGCToClientCraftworksUserDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCraftworksUserDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCraftworksUserDataUpdated\>\(CMsgGCToClientCraftworksUserDataUpdated, params CMsgGCToClientCraftworksUserDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated__ctor"></a> CMsgGCToClientCraftworksUserDataUpdated\(\)

```csharp
public CMsgGCToClientCraftworksUserDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_"></a> CMsgGCToClientCraftworksUserDataUpdated\(CMsgGCToClientCraftworksUserDataUpdated\)

```csharp
public CMsgGCToClientCraftworksUserDataUpdated(CMsgGCToClientCraftworksUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCraftworksUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCraftworksUserDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_CraftworksIdFieldNumber"></a> CraftworksIdFieldNumber

```csharp
public const int CraftworksIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_CraftworksId"></a> CraftworksId

```csharp
public uint CraftworksId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_HasCraftworksId"></a> HasCraftworksId

```csharp
public bool HasCraftworksId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCraftworksUserDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCraftworksUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCraftworksUserDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_UserData"></a> UserData

```csharp
public CMsgCraftworksUserData UserData { get; set; }
```

#### Property Value

 [CMsgCraftworksUserData](Divine.Protobufs.Dota2.CMsgCraftworksUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_ClearCraftworksId"></a> ClearCraftworksId\(\)

```csharp
public void ClearCraftworksId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCraftworksUserDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientCraftworksUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCraftworksUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_"></a> Equals\(CMsgGCToClientCraftworksUserDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientCraftworksUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCraftworksUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCraftworksUserDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_"></a> MergeFrom\(CMsgGCToClientCraftworksUserDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientCraftworksUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientCraftworksUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientCraftworksUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCraftworksUserDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

