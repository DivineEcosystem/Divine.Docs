# <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional"></a> Class CUserMessage\_PlayResponseConditional

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_PlayResponseConditional : IMessage<CUserMessage_PlayResponseConditional>, IEquatable<CUserMessage_PlayResponseConditional>, IDeepCloneable<CUserMessage_PlayResponseConditional>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_PlayResponseConditional](Divine.Protobufs.Dota2.CUserMessage\_PlayResponseConditional.md)

#### Implements

IMessage<CUserMessage\_PlayResponseConditional\>, 
[IEquatable<CUserMessage\_PlayResponseConditional\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_PlayResponseConditional\>, 
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
[EnumerableExtensions.In<CUserMessage\_PlayResponseConditional\>\(CUserMessage\_PlayResponseConditional, params CUserMessage\_PlayResponseConditional\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional__ctor"></a> CUserMessage\_PlayResponseConditional\(\)

```csharp
public CUserMessage_PlayResponseConditional()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional__ctor_Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_"></a> CUserMessage\_PlayResponseConditional\(CUserMessage\_PlayResponseConditional\)

```csharp
public CUserMessage_PlayResponseConditional(CUserMessage_PlayResponseConditional other)
```

#### Parameters

`other` [CUserMessage\_PlayResponseConditional](Divine.Protobufs.Dota2.CUserMessage\_PlayResponseConditional.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_EntIndexFieldNumber"></a> EntIndexFieldNumber

```csharp
public const int EntIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_EntOriginFieldNumber"></a> EntOriginFieldNumber

```csharp
public const int EntOriginFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_MixPriorityFieldNumber"></a> MixPriorityFieldNumber

```csharp
public const int MixPriorityFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_PlayerSlotsFieldNumber"></a> PlayerSlotsFieldNumber

```csharp
public const int PlayerSlotsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_PreDelayFieldNumber"></a> PreDelayFieldNumber

```csharp
public const int PreDelayFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_EntIndex"></a> EntIndex

```csharp
public int EntIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_EntOrigin"></a> EntOrigin

```csharp
public CMsgVector EntOrigin { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_HasEntIndex"></a> HasEntIndex

```csharp
public bool HasEntIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_HasMixPriority"></a> HasMixPriority

```csharp
public bool HasMixPriority { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_HasPreDelay"></a> HasPreDelay

```csharp
public bool HasPreDelay { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_MixPriority"></a> MixPriority

```csharp
public int MixPriority { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_PlayResponseConditional> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_PlayResponseConditional](Divine.Protobufs.Dota2.CUserMessage\_PlayResponseConditional.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_PlayerSlots"></a> PlayerSlots

```csharp
public RepeatedField<int> PlayerSlots { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_PreDelay"></a> PreDelay

```csharp
public float PreDelay { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_Response"></a> Response

```csharp
public string Response { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_ClearEntIndex"></a> ClearEntIndex\(\)

```csharp
public void ClearEntIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_ClearMixPriority"></a> ClearMixPriority\(\)

```csharp
public void ClearMixPriority()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_ClearPreDelay"></a> ClearPreDelay\(\)

```csharp
public void ClearPreDelay()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_Clone"></a> Clone\(\)

```csharp
public CUserMessage_PlayResponseConditional Clone()
```

#### Returns

 [CUserMessage\_PlayResponseConditional](Divine.Protobufs.Dota2.CUserMessage\_PlayResponseConditional.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_Equals_Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_"></a> Equals\(CUserMessage\_PlayResponseConditional\)

```csharp
public bool Equals(CUserMessage_PlayResponseConditional other)
```

#### Parameters

`other` [CUserMessage\_PlayResponseConditional](Divine.Protobufs.Dota2.CUserMessage\_PlayResponseConditional.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_"></a> MergeFrom\(CUserMessage\_PlayResponseConditional\)

```csharp
public void MergeFrom(CUserMessage_PlayResponseConditional other)
```

#### Parameters

`other` [CUserMessage\_PlayResponseConditional](Divine.Protobufs.Dota2.CUserMessage\_PlayResponseConditional.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_PlayResponseConditional_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

