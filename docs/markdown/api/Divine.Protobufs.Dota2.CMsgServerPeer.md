# <a id="Divine_Protobufs_Dota2_CMsgServerPeer"></a> Class CMsgServerPeer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerPeer : IMessage<CMsgServerPeer>, IEquatable<CMsgServerPeer>, IDeepCloneable<CMsgServerPeer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)

#### Implements

IMessage<CMsgServerPeer\>, 
[IEquatable<CMsgServerPeer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerPeer\>, 
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
[EnumerableExtensions.In<CMsgServerPeer\>\(CMsgServerPeer, params CMsgServerPeer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer__ctor"></a> CMsgServerPeer\(\)

```csharp
public CMsgServerPeer()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer__ctor_Divine_Protobufs_Dota2_CMsgServerPeer_"></a> CMsgServerPeer\(CMsgServerPeer\)

```csharp
public CMsgServerPeer(CMsgServerPeer other)
```

#### Parameters

`other` [CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_IpcFieldNumber"></a> IpcFieldNumber

```csharp
public const int IpcFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_IsListenserverHostFieldNumber"></a> IsListenserverHostFieldNumber

```csharp
public const int IsListenserverHostFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_PlayerSlotFieldNumber"></a> PlayerSlotFieldNumber

```csharp
public const int PlayerSlotFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_SteamidFieldNumber"></a> SteamidFieldNumber

```csharp
public const int SteamidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_TheyHearYouFieldNumber"></a> TheyHearYouFieldNumber

```csharp
public const int TheyHearYouFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_YouHearThemFieldNumber"></a> YouHearThemFieldNumber

```csharp
public const int YouHearThemFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_HasIsListenserverHost"></a> HasIsListenserverHost

```csharp
public bool HasIsListenserverHost { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_HasPlayerSlot"></a> HasPlayerSlot

```csharp
public bool HasPlayerSlot { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_HasSteamid"></a> HasSteamid

```csharp
public bool HasSteamid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_HasTheyHearYou"></a> HasTheyHearYou

```csharp
public bool HasTheyHearYou { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_HasYouHearThem"></a> HasYouHearThem

```csharp
public bool HasYouHearThem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Ipc"></a> Ipc

```csharp
public CMsgIPCAddress Ipc { get; set; }
```

#### Property Value

 [CMsgIPCAddress](Divine.Protobufs.Dota2.CMsgIPCAddress.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_IsListenserverHost"></a> IsListenserverHost

```csharp
public bool IsListenserverHost { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerPeer> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_PlayerSlot"></a> PlayerSlot

```csharp
public int PlayerSlot { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Steamid"></a> Steamid

```csharp
public ulong Steamid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_TheyHearYou"></a> TheyHearYou

```csharp
public bool TheyHearYou { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_YouHearThem"></a> YouHearThem

```csharp
public bool YouHearThem { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_ClearIsListenserverHost"></a> ClearIsListenserverHost\(\)

```csharp
public void ClearIsListenserverHost()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_ClearPlayerSlot"></a> ClearPlayerSlot\(\)

```csharp
public void ClearPlayerSlot()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_ClearSteamid"></a> ClearSteamid\(\)

```csharp
public void ClearSteamid()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_ClearTheyHearYou"></a> ClearTheyHearYou\(\)

```csharp
public void ClearTheyHearYou()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_ClearYouHearThem"></a> ClearYouHearThem\(\)

```csharp
public void ClearYouHearThem()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Clone"></a> Clone\(\)

```csharp
public CMsgServerPeer Clone()
```

#### Returns

 [CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_Equals_Divine_Protobufs_Dota2_CMsgServerPeer_"></a> Equals\(CMsgServerPeer\)

```csharp
public bool Equals(CMsgServerPeer other)
```

#### Parameters

`other` [CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_MergeFrom_Divine_Protobufs_Dota2_CMsgServerPeer_"></a> MergeFrom\(CMsgServerPeer\)

```csharp
public void MergeFrom(CMsgServerPeer other)
```

#### Parameters

`other` [CMsgServerPeer](Divine.Protobufs.Dota2.CMsgServerPeer.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerPeer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

