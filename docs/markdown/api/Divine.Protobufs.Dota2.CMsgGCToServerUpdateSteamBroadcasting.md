# <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting"></a> Class CMsgGCToServerUpdateSteamBroadcasting

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerUpdateSteamBroadcasting : IMessage<CMsgGCToServerUpdateSteamBroadcasting>, IEquatable<CMsgGCToServerUpdateSteamBroadcasting>, IDeepCloneable<CMsgGCToServerUpdateSteamBroadcasting>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerUpdateSteamBroadcasting](Divine.Protobufs.Dota2.CMsgGCToServerUpdateSteamBroadcasting.md)

#### Implements

IMessage<CMsgGCToServerUpdateSteamBroadcasting\>, 
[IEquatable<CMsgGCToServerUpdateSteamBroadcasting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerUpdateSteamBroadcasting\>, 
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
[EnumerableExtensions.In<CMsgGCToServerUpdateSteamBroadcasting\>\(CMsgGCToServerUpdateSteamBroadcasting, params CMsgGCToServerUpdateSteamBroadcasting\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting__ctor"></a> CMsgGCToServerUpdateSteamBroadcasting\(\)

```csharp
public CMsgGCToServerUpdateSteamBroadcasting()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting__ctor_Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_"></a> CMsgGCToServerUpdateSteamBroadcasting\(CMsgGCToServerUpdateSteamBroadcasting\)

```csharp
public CMsgGCToServerUpdateSteamBroadcasting(CMsgGCToServerUpdateSteamBroadcasting other)
```

#### Parameters

`other` [CMsgGCToServerUpdateSteamBroadcasting](Divine.Protobufs.Dota2.CMsgGCToServerUpdateSteamBroadcasting.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_ActiveFieldNumber"></a> ActiveFieldNumber

```csharp
public const int ActiveFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_Active"></a> Active

```csharp
public bool Active { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_HasActive"></a> HasActive

```csharp
public bool HasActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerUpdateSteamBroadcasting> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerUpdateSteamBroadcasting](Divine.Protobufs.Dota2.CMsgGCToServerUpdateSteamBroadcasting.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_ClearActive"></a> ClearActive\(\)

```csharp
public void ClearActive()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerUpdateSteamBroadcasting Clone()
```

#### Returns

 [CMsgGCToServerUpdateSteamBroadcasting](Divine.Protobufs.Dota2.CMsgGCToServerUpdateSteamBroadcasting.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_Equals_Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_"></a> Equals\(CMsgGCToServerUpdateSteamBroadcasting\)

```csharp
public bool Equals(CMsgGCToServerUpdateSteamBroadcasting other)
```

#### Parameters

`other` [CMsgGCToServerUpdateSteamBroadcasting](Divine.Protobufs.Dota2.CMsgGCToServerUpdateSteamBroadcasting.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_"></a> MergeFrom\(CMsgGCToServerUpdateSteamBroadcasting\)

```csharp
public void MergeFrom(CMsgGCToServerUpdateSteamBroadcasting other)
```

#### Parameters

`other` [CMsgGCToServerUpdateSteamBroadcasting](Divine.Protobufs.Dota2.CMsgGCToServerUpdateSteamBroadcasting.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerUpdateSteamBroadcasting_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

