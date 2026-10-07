# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert"></a> Class CDOTAUserMsg\_TipAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TipAlert : IMessage<CDOTAUserMsg_TipAlert>, IEquatable<CDOTAUserMsg_TipAlert>, IDeepCloneable<CDOTAUserMsg_TipAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TipAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_TipAlert\>, 
[IEquatable<CDOTAUserMsg\_TipAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TipAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TipAlert\>\(CDOTAUserMsg\_TipAlert, params CDOTAUserMsg\_TipAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert__ctor"></a> CDOTAUserMsg\_TipAlert\(\)

```csharp
public CDOTAUserMsg_TipAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_"></a> CDOTAUserMsg\_TipAlert\(CDOTAUserMsg\_TipAlert\)

```csharp
public CDOTAUserMsg_TipAlert(CDOTAUserMsg_TipAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TipAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_TipTextFieldNumber"></a> TipTextFieldNumber

```csharp
public const int TipTextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_HasTipText"></a> HasTipText

```csharp
public bool HasTipText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TipAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TipAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_TipText"></a> TipText

```csharp
public string TipText { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_ClearTipText"></a> ClearTipText\(\)

```csharp
public void ClearTipText()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TipAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TipAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_"></a> Equals\(CDOTAUserMsg\_TipAlert\)

```csharp
public bool Equals(CDOTAUserMsg_TipAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TipAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_"></a> MergeFrom\(CDOTAUserMsg\_TipAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_TipAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TipAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TipAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TipAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

