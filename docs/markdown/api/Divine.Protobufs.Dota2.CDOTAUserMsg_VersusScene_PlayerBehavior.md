# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior"></a> Class CDOTAUserMsg\_VersusScene\_PlayerBehavior

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_VersusScene_PlayerBehavior : IMessage<CDOTAUserMsg_VersusScene_PlayerBehavior>, IEquatable<CDOTAUserMsg_VersusScene_PlayerBehavior>, IDeepCloneable<CDOTAUserMsg_VersusScene_PlayerBehavior>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_VersusScene\_PlayerBehavior](Divine.Protobufs.Dota2.CDOTAUserMsg\_VersusScene\_PlayerBehavior.md)

#### Implements

IMessage<CDOTAUserMsg\_VersusScene\_PlayerBehavior\>, 
[IEquatable<CDOTAUserMsg\_VersusScene\_PlayerBehavior\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_VersusScene\_PlayerBehavior\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_VersusScene\_PlayerBehavior\>\(CDOTAUserMsg\_VersusScene\_PlayerBehavior, params CDOTAUserMsg\_VersusScene\_PlayerBehavior\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior__ctor"></a> CDOTAUserMsg\_VersusScene\_PlayerBehavior\(\)

```csharp
public CDOTAUserMsg_VersusScene_PlayerBehavior()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_"></a> CDOTAUserMsg\_VersusScene\_PlayerBehavior\(CDOTAUserMsg\_VersusScene\_PlayerBehavior\)

```csharp
public CDOTAUserMsg_VersusScene_PlayerBehavior(CDOTAUserMsg_VersusScene_PlayerBehavior other)
```

#### Parameters

`other` [CDOTAUserMsg\_VersusScene\_PlayerBehavior](Divine.Protobufs.Dota2.CDOTAUserMsg\_VersusScene\_PlayerBehavior.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_BehaviorFieldNumber"></a> BehaviorFieldNumber

```csharp
public const int BehaviorFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_ChatWheelFieldNumber"></a> ChatWheelFieldNumber

```csharp
public const int ChatWheelFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_PlayActivityFieldNumber"></a> PlayActivityFieldNumber

```csharp
public const int PlayActivityFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_PlaybackRateFieldNumber"></a> PlaybackRateFieldNumber

```csharp
public const int PlaybackRateFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_Behavior"></a> Behavior

```csharp
public EDOTAVersusScenePlayerBehavior Behavior { get; set; }
```

#### Property Value

 [EDOTAVersusScenePlayerBehavior](Divine.Protobufs.Dota2.EDOTAVersusScenePlayerBehavior.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_ChatWheel"></a> ChatWheel

```csharp
public VersusScene_ChatWheel ChatWheel { get; set; }
```

#### Property Value

 [VersusScene\_ChatWheel](Divine.Protobufs.Dota2.VersusScene\_ChatWheel.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_HasBehavior"></a> HasBehavior

```csharp
public bool HasBehavior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_VersusScene_PlayerBehavior> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_VersusScene\_PlayerBehavior](Divine.Protobufs.Dota2.CDOTAUserMsg\_VersusScene\_PlayerBehavior.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_PlayActivity"></a> PlayActivity

```csharp
public VersusScene_PlayActivity PlayActivity { get; set; }
```

#### Property Value

 [VersusScene\_PlayActivity](Divine.Protobufs.Dota2.VersusScene\_PlayActivity.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_PlaybackRate"></a> PlaybackRate

```csharp
public VersusScene_PlaybackRate PlaybackRate { get; set; }
```

#### Property Value

 [VersusScene\_PlaybackRate](Divine.Protobufs.Dota2.VersusScene\_PlaybackRate.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_ClearBehavior"></a> ClearBehavior\(\)

```csharp
public void ClearBehavior()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_VersusScene_PlayerBehavior Clone()
```

#### Returns

 [CDOTAUserMsg\_VersusScene\_PlayerBehavior](Divine.Protobufs.Dota2.CDOTAUserMsg\_VersusScene\_PlayerBehavior.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_"></a> Equals\(CDOTAUserMsg\_VersusScene\_PlayerBehavior\)

```csharp
public bool Equals(CDOTAUserMsg_VersusScene_PlayerBehavior other)
```

#### Parameters

`other` [CDOTAUserMsg\_VersusScene\_PlayerBehavior](Divine.Protobufs.Dota2.CDOTAUserMsg\_VersusScene\_PlayerBehavior.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_"></a> MergeFrom\(CDOTAUserMsg\_VersusScene\_PlayerBehavior\)

```csharp
public void MergeFrom(CDOTAUserMsg_VersusScene_PlayerBehavior other)
```

#### Parameters

`other` [CDOTAUserMsg\_VersusScene\_PlayerBehavior](Divine.Protobufs.Dota2.CDOTAUserMsg\_VersusScene\_PlayerBehavior.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VersusScene_PlayerBehavior_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

