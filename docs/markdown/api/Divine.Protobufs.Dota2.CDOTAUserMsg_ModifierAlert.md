# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert"></a> Class CDOTAUserMsg\_ModifierAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ModifierAlert : IMessage<CDOTAUserMsg_ModifierAlert>, IEquatable<CDOTAUserMsg_ModifierAlert>, IDeepCloneable<CDOTAUserMsg_ModifierAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ModifierAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_ModifierAlert\>, 
[IEquatable<CDOTAUserMsg\_ModifierAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ModifierAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ModifierAlert\>\(CDOTAUserMsg\_ModifierAlert, params CDOTAUserMsg\_ModifierAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert__ctor"></a> CDOTAUserMsg\_ModifierAlert\(\)

```csharp
public CDOTAUserMsg_ModifierAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_"></a> CDOTAUserMsg\_ModifierAlert\(CDOTAUserMsg\_ModifierAlert\)

```csharp
public CDOTAUserMsg_ModifierAlert(CDOTAUserMsg_ModifierAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ModifierAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClassNameFieldNumber"></a> ClassNameFieldNumber

```csharp
public const int ClassNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_IsDebuffFieldNumber"></a> IsDebuffFieldNumber

```csharp
public const int IsDebuffFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_SecondsRemainingFieldNumber"></a> SecondsRemainingFieldNumber

```csharp
public const int SecondsRemainingFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_StackCountFieldNumber"></a> StackCountFieldNumber

```csharp
public const int StackCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_TargetEntindexFieldNumber"></a> TargetEntindexFieldNumber

```csharp
public const int TargetEntindexFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClassName"></a> ClassName

```csharp
public string ClassName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_HasClassName"></a> HasClassName

```csharp
public bool HasClassName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_HasIsDebuff"></a> HasIsDebuff

```csharp
public bool HasIsDebuff { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_HasSecondsRemaining"></a> HasSecondsRemaining

```csharp
public bool HasSecondsRemaining { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_HasStackCount"></a> HasStackCount

```csharp
public bool HasStackCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_HasTargetEntindex"></a> HasTargetEntindex

```csharp
public bool HasTargetEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_IsDebuff"></a> IsDebuff

```csharp
public bool IsDebuff { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ModifierAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ModifierAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_SecondsRemaining"></a> SecondsRemaining

```csharp
public float SecondsRemaining { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_StackCount"></a> StackCount

```csharp
public uint StackCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_TargetEntindex"></a> TargetEntindex

```csharp
public int TargetEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClearClassName"></a> ClearClassName\(\)

```csharp
public void ClearClassName()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClearIsDebuff"></a> ClearIsDebuff\(\)

```csharp
public void ClearIsDebuff()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClearSecondsRemaining"></a> ClearSecondsRemaining\(\)

```csharp
public void ClearSecondsRemaining()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClearStackCount"></a> ClearStackCount\(\)

```csharp
public void ClearStackCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ClearTargetEntindex"></a> ClearTargetEntindex\(\)

```csharp
public void ClearTargetEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ModifierAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ModifierAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_"></a> Equals\(CDOTAUserMsg\_ModifierAlert\)

```csharp
public bool Equals(CDOTAUserMsg_ModifierAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ModifierAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_"></a> MergeFrom\(CDOTAUserMsg\_ModifierAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_ModifierAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_ModifierAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_ModifierAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ModifierAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

