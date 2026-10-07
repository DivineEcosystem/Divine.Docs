# <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response"></a> Class CUserMessage\_Inventory\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_Inventory_Response : IMessage<CUserMessage_Inventory_Response>, IEquatable<CUserMessage_Inventory_Response>, IDeepCloneable<CUserMessage_Inventory_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md)

#### Implements

IMessage<CUserMessage\_Inventory\_Response\>, 
[IEquatable<CUserMessage\_Inventory\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_Inventory\_Response\>, 
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
[EnumerableExtensions.In<CUserMessage\_Inventory\_Response\>\(CUserMessage\_Inventory\_Response, params CUserMessage\_Inventory\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response__ctor"></a> CUserMessage\_Inventory\_Response\(\)

```csharp
public CUserMessage_Inventory_Response()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response__ctor_Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_"></a> CUserMessage\_Inventory\_Response\(CUserMessage\_Inventory\_Response\)

```csharp
public CUserMessage_Inventory_Response(CUserMessage_Inventory_Response other)
```

#### Parameters

`other` [CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_BuildVersionFieldNumber"></a> BuildVersionFieldNumber

```csharp
public const int BuildVersionFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClientTimestampFieldNumber"></a> ClientTimestampFieldNumber

```csharp
public const int ClientTimestampFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_CrcFieldNumber"></a> CrcFieldNumber

```csharp
public const int CrcFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_InstanceFieldNumber"></a> InstanceFieldNumber

```csharp
public const int InstanceFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Inventories2FieldNumber"></a> Inventories2FieldNumber

```csharp
public const int Inventories2FieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Inventories3FieldNumber"></a> Inventories3FieldNumber

```csharp
public const int Inventories3FieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_InventoriesFieldNumber"></a> InventoriesFieldNumber

```csharp
public const int InventoriesFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_InvTypeFieldNumber"></a> InvTypeFieldNumber

```csharp
public const int InvTypeFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ItemCountFieldNumber"></a> ItemCountFieldNumber

```csharp
public const int ItemCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_OsversionFieldNumber"></a> OsversionFieldNumber

```csharp
public const int OsversionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_PerfTimeFieldNumber"></a> PerfTimeFieldNumber

```csharp
public const int PerfTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_PlatformFieldNumber"></a> PlatformFieldNumber

```csharp
public const int PlatformFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_BuildVersion"></a> BuildVersion

```csharp
public int BuildVersion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClientTimestamp"></a> ClientTimestamp

```csharp
public int ClientTimestamp { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Crc"></a> Crc

```csharp
public uint Crc { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasBuildVersion"></a> HasBuildVersion

```csharp
public bool HasBuildVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasClientTimestamp"></a> HasClientTimestamp

```csharp
public bool HasClientTimestamp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasCrc"></a> HasCrc

```csharp
public bool HasCrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasInstance"></a> HasInstance

```csharp
public bool HasInstance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasInvType"></a> HasInvType

```csharp
public bool HasInvType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasItemCount"></a> HasItemCount

```csharp
public bool HasItemCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasOsversion"></a> HasOsversion

```csharp
public bool HasOsversion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasPerfTime"></a> HasPerfTime

```csharp
public bool HasPerfTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasPlatform"></a> HasPlatform

```csharp
public bool HasPlatform { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Instance"></a> Instance

```csharp
public int Instance { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Inventories"></a> Inventories

```csharp
public RepeatedField<CUserMessage_Inventory_Response.Types.InventoryDetail> Inventories { get; }
```

#### Property Value

 RepeatedField<[CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.Types.md).[InventoryDetail](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.Types.InventoryDetail.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Inventories2"></a> Inventories2

```csharp
public RepeatedField<CUserMessage_Inventory_Response.Types.InventoryDetail> Inventories2 { get; }
```

#### Property Value

 RepeatedField<[CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.Types.md).[InventoryDetail](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.Types.InventoryDetail.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Inventories3"></a> Inventories3

```csharp
public RepeatedField<CUserMessage_Inventory_Response.Types.InventoryDetail> Inventories3 { get; }
```

#### Property Value

 RepeatedField<[CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.Types.md).[InventoryDetail](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.Types.InventoryDetail.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_InvType"></a> InvType

```csharp
public int InvType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ItemCount"></a> ItemCount

```csharp
public int ItemCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Osversion"></a> Osversion

```csharp
public int Osversion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_Inventory_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_PerfTime"></a> PerfTime

```csharp
public int PerfTime { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Platform"></a> Platform

```csharp
public int Platform { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_StartTime"></a> StartTime

```csharp
public long StartTime { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearBuildVersion"></a> ClearBuildVersion\(\)

```csharp
public void ClearBuildVersion()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearClientTimestamp"></a> ClearClientTimestamp\(\)

```csharp
public void ClearClientTimestamp()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearCrc"></a> ClearCrc\(\)

```csharp
public void ClearCrc()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearInstance"></a> ClearInstance\(\)

```csharp
public void ClearInstance()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearInvType"></a> ClearInvType\(\)

```csharp
public void ClearInvType()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearItemCount"></a> ClearItemCount\(\)

```csharp
public void ClearItemCount()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearOsversion"></a> ClearOsversion\(\)

```csharp
public void ClearOsversion()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearPerfTime"></a> ClearPerfTime\(\)

```csharp
public void ClearPerfTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearPlatform"></a> ClearPlatform\(\)

```csharp
public void ClearPlatform()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Clone"></a> Clone\(\)

```csharp
public CUserMessage_Inventory_Response Clone()
```

#### Returns

 [CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_Equals_Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_"></a> Equals\(CUserMessage\_Inventory\_Response\)

```csharp
public bool Equals(CUserMessage_Inventory_Response other)
```

#### Parameters

`other` [CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_"></a> MergeFrom\(CUserMessage\_Inventory\_Response\)

```csharp
public void MergeFrom(CUserMessage_Inventory_Response other)
```

#### Parameters

`other` [CUserMessage\_Inventory\_Response](Divine.Protobufs.Dota2.CUserMessage\_Inventory\_Response.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Inventory_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

