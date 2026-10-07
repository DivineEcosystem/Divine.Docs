# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter"></a> Class CMsgDOTATeamInvite\_GCResponseToInviter

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInvite_GCResponseToInviter : IMessage<CMsgDOTATeamInvite_GCResponseToInviter>, IEquatable<CMsgDOTATeamInvite_GCResponseToInviter>, IDeepCloneable<CMsgDOTATeamInvite_GCResponseToInviter>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInvite\_GCResponseToInviter](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInviter.md)

#### Implements

IMessage<CMsgDOTATeamInvite\_GCResponseToInviter\>, 
[IEquatable<CMsgDOTATeamInvite\_GCResponseToInviter\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInvite\_GCResponseToInviter\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInvite\_GCResponseToInviter\>\(CMsgDOTATeamInvite\_GCResponseToInviter, params CMsgDOTATeamInvite\_GCResponseToInviter\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter__ctor"></a> CMsgDOTATeamInvite\_GCResponseToInviter\(\)

```csharp
public CMsgDOTATeamInvite_GCResponseToInviter()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_"></a> CMsgDOTATeamInvite\_GCResponseToInviter\(CMsgDOTATeamInvite\_GCResponseToInviter\)

```csharp
public CMsgDOTATeamInvite_GCResponseToInviter(CMsgDOTATeamInvite_GCResponseToInviter other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCResponseToInviter](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInviter.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_InviteeNameFieldNumber"></a> InviteeNameFieldNumber

```csharp
public const int InviteeNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_HasInviteeName"></a> HasInviteeName

```csharp
public bool HasInviteeName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_InviteeName"></a> InviteeName

```csharp
public string InviteeName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInvite_GCResponseToInviter> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInvite\_GCResponseToInviter](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInviter.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_Result"></a> Result

```csharp
public ETeamInviteResult Result { get; set; }
```

#### Property Value

 [ETeamInviteResult](Divine.Protobufs.Dota2.ETeamInviteResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_ClearInviteeName"></a> ClearInviteeName\(\)

```csharp
public void ClearInviteeName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInvite_GCResponseToInviter Clone()
```

#### Returns

 [CMsgDOTATeamInvite\_GCResponseToInviter](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInviter.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_"></a> Equals\(CMsgDOTATeamInvite\_GCResponseToInviter\)

```csharp
public bool Equals(CMsgDOTATeamInvite_GCResponseToInviter other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCResponseToInviter](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInviter.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_"></a> MergeFrom\(CMsgDOTATeamInvite\_GCResponseToInviter\)

```csharp
public void MergeFrom(CMsgDOTATeamInvite_GCResponseToInviter other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCResponseToInviter](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInviter.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInviter_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

