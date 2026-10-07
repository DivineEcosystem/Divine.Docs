# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC"></a> Class CMsgDOTATeamInvite\_InviteeResponseToGC

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInvite_InviteeResponseToGC : IMessage<CMsgDOTATeamInvite_InviteeResponseToGC>, IEquatable<CMsgDOTATeamInvite_InviteeResponseToGC>, IDeepCloneable<CMsgDOTATeamInvite_InviteeResponseToGC>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInvite\_InviteeResponseToGC](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_InviteeResponseToGC.md)

#### Implements

IMessage<CMsgDOTATeamInvite\_InviteeResponseToGC\>, 
[IEquatable<CMsgDOTATeamInvite\_InviteeResponseToGC\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInvite\_InviteeResponseToGC\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInvite\_InviteeResponseToGC\>\(CMsgDOTATeamInvite\_InviteeResponseToGC, params CMsgDOTATeamInvite\_InviteeResponseToGC\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC__ctor"></a> CMsgDOTATeamInvite\_InviteeResponseToGC\(\)

```csharp
public CMsgDOTATeamInvite_InviteeResponseToGC()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_"></a> CMsgDOTATeamInvite\_InviteeResponseToGC\(CMsgDOTATeamInvite\_InviteeResponseToGC\)

```csharp
public CMsgDOTATeamInvite_InviteeResponseToGC(CMsgDOTATeamInvite_InviteeResponseToGC other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_InviteeResponseToGC](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_InviteeResponseToGC.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInvite_InviteeResponseToGC> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInvite\_InviteeResponseToGC](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_InviteeResponseToGC.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_Result"></a> Result

```csharp
public ETeamInviteResult Result { get; set; }
```

#### Property Value

 [ETeamInviteResult](Divine.Protobufs.Dota2.ETeamInviteResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInvite_InviteeResponseToGC Clone()
```

#### Returns

 [CMsgDOTATeamInvite\_InviteeResponseToGC](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_InviteeResponseToGC.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_"></a> Equals\(CMsgDOTATeamInvite\_InviteeResponseToGC\)

```csharp
public bool Equals(CMsgDOTATeamInvite_InviteeResponseToGC other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_InviteeResponseToGC](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_InviteeResponseToGC.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_"></a> MergeFrom\(CMsgDOTATeamInvite\_InviteeResponseToGC\)

```csharp
public void MergeFrom(CMsgDOTATeamInvite_InviteeResponseToGC other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_InviteeResponseToGC](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_InviteeResponseToGC.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_InviteeResponseToGC_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

