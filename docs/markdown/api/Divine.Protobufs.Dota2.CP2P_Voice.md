# <a id="Divine_Protobufs_Dota2_CP2P_Voice"></a> Class CP2P\_Voice

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CP2P_Voice : IMessage<CP2P_Voice>, IEquatable<CP2P_Voice>, IDeepCloneable<CP2P_Voice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CP2P\_Voice](Divine.Protobufs.Dota2.CP2P\_Voice.md)

#### Implements

IMessage<CP2P\_Voice\>, 
[IEquatable<CP2P\_Voice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CP2P\_Voice\>, 
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
[EnumerableExtensions.In<CP2P\_Voice\>\(CP2P\_Voice, params CP2P\_Voice\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CP2P_Voice__ctor"></a> CP2P\_Voice\(\)

```csharp
public CP2P_Voice()
```

### <a id="Divine_Protobufs_Dota2_CP2P_Voice__ctor_Divine_Protobufs_Dota2_CP2P_Voice_"></a> CP2P\_Voice\(CP2P\_Voice\)

```csharp
public CP2P_Voice(CP2P_Voice other)
```

#### Parameters

`other` [CP2P\_Voice](Divine.Protobufs.Dota2.CP2P\_Voice.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_AudioFieldNumber"></a> AudioFieldNumber

```csharp
public const int AudioFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_BroadcastGroupFieldNumber"></a> BroadcastGroupFieldNumber

```csharp
public const int BroadcastGroupFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_Audio"></a> Audio

```csharp
public CMsgVoiceAudio Audio { get; set; }
```

#### Property Value

 [CMsgVoiceAudio](Divine.Protobufs.Dota2.CMsgVoiceAudio.md)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_BroadcastGroup"></a> BroadcastGroup

```csharp
public uint BroadcastGroup { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_HasBroadcastGroup"></a> HasBroadcastGroup

```csharp
public bool HasBroadcastGroup { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_Parser"></a> Parser

```csharp
public static MessageParser<CP2P_Voice> Parser { get; }
```

#### Property Value

 MessageParser<[CP2P\_Voice](Divine.Protobufs.Dota2.CP2P\_Voice.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_ClearBroadcastGroup"></a> ClearBroadcastGroup\(\)

```csharp
public void ClearBroadcastGroup()
```

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_Clone"></a> Clone\(\)

```csharp
public CP2P_Voice Clone()
```

#### Returns

 [CP2P\_Voice](Divine.Protobufs.Dota2.CP2P\_Voice.md)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_Equals_Divine_Protobufs_Dota2_CP2P_Voice_"></a> Equals\(CP2P\_Voice\)

```csharp
public bool Equals(CP2P_Voice other)
```

#### Parameters

`other` [CP2P\_Voice](Divine.Protobufs.Dota2.CP2P\_Voice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_MergeFrom_Divine_Protobufs_Dota2_CP2P_Voice_"></a> MergeFrom\(CP2P\_Voice\)

```csharp
public void MergeFrom(CP2P_Voice other)
```

#### Parameters

`other` [CP2P\_Voice](Divine.Protobufs.Dota2.CP2P\_Voice.md)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CP2P_Voice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

