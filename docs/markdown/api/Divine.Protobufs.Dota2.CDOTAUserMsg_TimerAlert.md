# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert"></a> Class CDOTAUserMsg\_TimerAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TimerAlert : IMessage<CDOTAUserMsg_TimerAlert>, IEquatable<CDOTAUserMsg_TimerAlert>, IDeepCloneable<CDOTAUserMsg_TimerAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TimerAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TimerAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_TimerAlert\>, 
[IEquatable<CDOTAUserMsg\_TimerAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TimerAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TimerAlert\>\(CDOTAUserMsg\_TimerAlert, params CDOTAUserMsg\_TimerAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert__ctor"></a> CDOTAUserMsg\_TimerAlert\(\)

```csharp
public CDOTAUserMsg_TimerAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_"></a> CDOTAUserMsg\_TimerAlert\(CDOTAUserMsg\_TimerAlert\)

```csharp
public CDOTAUserMsg_TimerAlert(CDOTAUserMsg_TimerAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TimerAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TimerAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_TimerAlertTypeFieldNumber"></a> TimerAlertTypeFieldNumber

```csharp
public const int TimerAlertTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_HasTimerAlertType"></a> HasTimerAlertType

```csharp
public bool HasTimerAlertType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TimerAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TimerAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TimerAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_TimerAlertType"></a> TimerAlertType

```csharp
public ETimerAlertType TimerAlertType { get; set; }
```

#### Property Value

 [ETimerAlertType](Divine.Protobufs.Dota2.ETimerAlertType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_ClearTimerAlertType"></a> ClearTimerAlertType\(\)

```csharp
public void ClearTimerAlertType()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TimerAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_TimerAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TimerAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_"></a> Equals\(CDOTAUserMsg\_TimerAlert\)

```csharp
public bool Equals(CDOTAUserMsg_TimerAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TimerAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TimerAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_"></a> MergeFrom\(CDOTAUserMsg\_TimerAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_TimerAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_TimerAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_TimerAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TimerAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

