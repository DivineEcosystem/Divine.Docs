# <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus"></a> Class CSVCMsg\_HLTVStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_HLTVStatus : IMessage<CSVCMsg_HLTVStatus>, IEquatable<CSVCMsg_HLTVStatus>, IDeepCloneable<CSVCMsg_HLTVStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_HLTVStatus](Divine.Protobufs.Dota2.CSVCMsg\_HLTVStatus.md)

#### Implements

IMessage<CSVCMsg\_HLTVStatus\>, 
[IEquatable<CSVCMsg\_HLTVStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_HLTVStatus\>, 
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
[EnumerableExtensions.In<CSVCMsg\_HLTVStatus\>\(CSVCMsg\_HLTVStatus, params CSVCMsg\_HLTVStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus__ctor"></a> CSVCMsg\_HLTVStatus\(\)

```csharp
public CSVCMsg_HLTVStatus()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus__ctor_Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_"></a> CSVCMsg\_HLTVStatus\(CSVCMsg\_HLTVStatus\)

```csharp
public CSVCMsg_HLTVStatus(CSVCMsg_HLTVStatus other)
```

#### Parameters

`other` [CSVCMsg\_HLTVStatus](Divine.Protobufs.Dota2.CSVCMsg\_HLTVStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ClientsFieldNumber"></a> ClientsFieldNumber

```csharp
public const int ClientsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_MasterFieldNumber"></a> MasterFieldNumber

```csharp
public const int MasterFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ProxiesFieldNumber"></a> ProxiesFieldNumber

```csharp
public const int ProxiesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_SlotsFieldNumber"></a> SlotsFieldNumber

```csharp
public const int SlotsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Clients"></a> Clients

```csharp
public int Clients { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_HasClients"></a> HasClients

```csharp
public bool HasClients { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_HasMaster"></a> HasMaster

```csharp
public bool HasMaster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_HasProxies"></a> HasProxies

```csharp
public bool HasProxies { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_HasSlots"></a> HasSlots

```csharp
public bool HasSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Master"></a> Master

```csharp
public string Master { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_HLTVStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_HLTVStatus](Divine.Protobufs.Dota2.CSVCMsg\_HLTVStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Proxies"></a> Proxies

```csharp
public int Proxies { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Slots"></a> Slots

```csharp
public int Slots { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ClearClients"></a> ClearClients\(\)

```csharp
public void ClearClients()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ClearMaster"></a> ClearMaster\(\)

```csharp
public void ClearMaster()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ClearProxies"></a> ClearProxies\(\)

```csharp
public void ClearProxies()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ClearSlots"></a> ClearSlots\(\)

```csharp
public void ClearSlots()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_HLTVStatus Clone()
```

#### Returns

 [CSVCMsg\_HLTVStatus](Divine.Protobufs.Dota2.CSVCMsg\_HLTVStatus.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_Equals_Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_"></a> Equals\(CSVCMsg\_HLTVStatus\)

```csharp
public bool Equals(CSVCMsg_HLTVStatus other)
```

#### Parameters

`other` [CSVCMsg\_HLTVStatus](Divine.Protobufs.Dota2.CSVCMsg\_HLTVStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_"></a> MergeFrom\(CSVCMsg\_HLTVStatus\)

```csharp
public void MergeFrom(CSVCMsg_HLTVStatus other)
```

#### Parameters

`other` [CSVCMsg\_HLTVStatus](Divine.Protobufs.Dota2.CSVCMsg\_HLTVStatus.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_HLTVStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

